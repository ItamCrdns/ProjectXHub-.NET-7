﻿using CompanyPMO_.NET.Common;
using CompanyPMO_.NET.Dto;
using CompanyPMO_.NET.Models;

namespace CompanyPMO_.NET.Interfaces.Project_interfaces
{
    public interface IProjectManagement
    {
        // PENDING: Implement AddImagesToExistingProject in Project Management Controller
        Task<OperationResult<int>> CreateProject(Project project, int employeeSupervisorId, List<IFormFile>? images, int companyId, List<int>? employees, bool shouldStartNow);
        Task<(bool updated, ProjectDto)> UpdateProject(int employeeId, int projectId, ProjectDto projectDto, List<IFormFile>? images);
        Task<(string status, IEnumerable<ImageDto>)> AddImagesToExistingProject(int projectId, List<IFormFile>? images);
        Task<(string status, IEnumerable<EmployeeShowcaseDto>)> AddEmployeesToProject(int projectId, List<int> employees);
        Task<OperationResult<int[]>> SetProjectsFininishedBulk(int[] projectIds);
        Task<bool> SetProjectFinalized(int projectId);
    }
}
