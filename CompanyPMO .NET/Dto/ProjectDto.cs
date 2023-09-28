﻿using CompanyPMO_.NET.Models;

namespace CompanyPMO_.NET.Dto
{
    public class ProjectDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<ImageDto>? Images { get; set; }
    }
}
