﻿using CompanyPMO_.NET.Common;
using CompanyPMO_.NET.Dto;
using CompanyPMO_.NET.Interfaces.Timeline_interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CompanyPMO_.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimelineManagementController : ControllerBase
    {
        private readonly ITimelineManagement _timelineManagement;
        public TimelineManagementController(ITimelineManagement timelineManagement)
        {
            _timelineManagement = timelineManagement;
        }
        [Authorize(Policy = "EmployeesAllowed")]
        [HttpPost("on-logout")]
        [ProducesResponseType(200, Type = typeof(OperationResult))]
        [ProducesResponseType(401)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> AddTimelineEventOnUserLogout()
        {
            var claim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            var usernameClaim = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name).Value;

            if (claim == null || usernameClaim == null)
            {
                return Unauthorized("User ID claim or Username claim is missing");
            }

            int employeeId = int.Parse(claim.Value);

            var timeline = new TimelineDto
            {
                Event = $"{usernameClaim} logged out",
                EmployeeId = employeeId,
                Type = TimelineType.Logout
            };

            var result = await _timelineManagement.CreateTimelineEvent(timeline);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
