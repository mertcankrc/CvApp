using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.EducationComponent
{
    public class EducationComponent : MainComponent
    {

        private readonly IEducationService _educationService;
        private readonly IMapper _mapper;

        public EducationComponent(IEducationService educationService, IMapper mapper)
        {
            _educationService = educationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDTO>>(_educationService.GetByLanguage(GetCulture())));
        }
    }
}
