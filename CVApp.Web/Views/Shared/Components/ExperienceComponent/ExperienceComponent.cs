using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.ExperienceDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.ExperienceComponent
{
    public class ExperienceComponent : MainComponent
    {

        private readonly IExperienceService _experienceService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IExperienceService experienceservice, IMapper mapper)
        {
            _experienceService = experienceservice;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDTO>>(_experienceService.GetByLanguage(GetCulture()).OrderByDescending(x=>x.StartDate)));
        }
    }
}
