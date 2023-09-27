﻿using CompanyPMO_.NET.Dto;
using CompanyPMO_.NET.Interfaces;
using CompanyPMO_.NET.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyPMO_.NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany _companyService;
        private readonly IUserIdentity _userIdentityService;
        private readonly Lazy<Task<int>> _lazyUserId;

        public CompanyController(ICompany companyService, IUserIdentity userIdentityService)
        {
            _companyService = companyService;
            _userIdentityService = userIdentityService;
            _lazyUserId = new Lazy<Task<int>>(InitializeUserId);
        }

        private async Task<int> InitializeUserId()
        {
            return await _userIdentityService.GetUserIdFromClaims(HttpContext.User);
        }

        private async Task<int> GetUserId()
        {
            return await _lazyUserId.Value;
        }

        [Authorize(Policy = "SupervisorOnly")]
        [HttpPost("new")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Company>))]
        [ProducesResponseType(500)]
        public async Task<IActionResult> NewCompany([FromForm] CompanyDto newCompany, [FromForm] List<IFormFile>? images)
        {
            var (created, returnedCompany) = await _companyService.AddCompany(await GetUserId(), newCompany, images);

            if(!created)
            {
                return StatusCode(500, "Something went wrong");
            }

            return Ok(returnedCompany);
        }

        //[Authorize(Policy = "SupervisorOnly")]
        //[HttpPost("{companyId}/images/new")]
        //[ProducesResponseType(200, Type = typeof(IEnumerable<Image>))]
        //public async Task<IActionResult> AddImagesToExistingCompany([FromForm] List<IFormFile>? images)
        //{

        //}
    }
}
