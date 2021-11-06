using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.AboutComponent
{
    public class AboutComponent : MainComponent
    {
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AboutComponent(IAppUserService appUserService, IMapper mapper)
        {
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            
            return View(_mapper.Map<AppUserListDTO>(_appUserService.GetByLanguage(GetCulture())));
        }
    }
}
