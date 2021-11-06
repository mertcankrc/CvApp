using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.DTO.DTO.ProjectsDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.ProjectComponent
{
    public class ProjectComponent : MainComponent
    {

        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public ProjectComponent(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ProjectsListDTO>>(_projectService.GetByLanguage(GetCulture())));
        }
    }
}
