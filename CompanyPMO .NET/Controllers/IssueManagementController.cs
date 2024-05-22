﻿using CompanyPMO_.NET.Common;
using CompanyPMO_.NET.Dto;
using CompanyPMO_.NET.Interfaces.Issue_interfaces;
using CompanyPMO_.NET.Interfaces.Timeline_interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CompanyPMO_.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueManagementController : ControllerBase
    {
        private readonly IIssueManagement _issueManagement;
        private readonly ITimelineManagement _timelineManagement;
        public IssueManagementController(IIssueManagement issueManagement, ITimelineManagement timelineManagement)
        {
            _issueManagement = issueManagement;
            _timelineManagement = timelineManagement;
        }

        [Authorize(Policy = "SupervisorOnly")]
        [HttpPost("create")]
        [ProducesResponseType(200, Type = typeof(OperationResult<int>))]
        [ProducesResponseType(400, Type = typeof(OperationResult<int>))]
        public async Task<IActionResult> CreateIssue([FromBody] IssueDto issue, [FromQuery] int taskId, [FromQuery] bool shouldStartNow)
        {
            var claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;

            if (claim == null || usernameClaim == null)
            {
                return Unauthorized("User ID claim or Username claim is missing");
            }

            int employeeId = int.Parse(claim.Value);

            var result = await _issueManagement.CreateIssue(issue, employeeId, taskId, shouldStartNow);

            if (!result.Success)
                return BadRequest(result);

            var timelineEvent = new TimelineDto
            {
                Event = $"{usernameClaim} created an issue",
                EmployeeId = employeeId,
                Type = TimelineType.Create,
                IssueId = result.Data
            };

            await _timelineManagement.CreateTimelineEvent(timelineEvent);

            return Ok(result);
        }
    }
}
