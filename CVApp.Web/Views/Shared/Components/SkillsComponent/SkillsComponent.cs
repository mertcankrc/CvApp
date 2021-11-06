using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.SkillDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.SkillsComponent
{
    public class SkillsComponent : MainComponent
    {

        private readonly ISkillService _skillService;
        private readonly IMapper _mapper;

        public SkillsComponent(ISkillService skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDTO>>(_skillService.GetByLanguage(GetCulture())));
        }
    }
}
