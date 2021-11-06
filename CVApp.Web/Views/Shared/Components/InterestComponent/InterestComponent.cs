using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.InterestDTO;
using CVApp.DTO.DTO.SkillDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.InterestComponent
{
    public class InterestComponent : MainComponent
    {

        private readonly IInterestService _interestService;
        private readonly IMapper _mapper;

        public InterestComponent(IInterestService interestService, IMapper mapper)
        {
            _interestService = interestService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDTO>>(_interestService.GetByLanguage(GetCulture())));
        }
    }
}
