﻿using CompanyPMO_.NET.Dto;
using CompanyPMO_.NET.Models;

namespace CompanyPMO_.NET.Interfaces
{
    public interface ICompany
    {
        Task<Company> GetCompany(int companyId);
        Task<(bool created, Company)> AddCompany(int supervisorId, CompanyDto companyDto, List<IFormFile>? images);
        Task<(bool updated, CompanyDto)> UpdateCompany(int employeeId, int companyId, CompanyDto companyDto, List<IFormFile>? images);
        Task<Company> GetCompanyById(int companyId);
        Task<bool> DoesCompanyExist(int companyId);
        Task<IEnumerable<ImageDto>> AddImagesToExistingCompany(int companyId, List<IFormFile>? images);
    }
}
