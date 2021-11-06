using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.NavbarComponent
{
    public class NavbarComponent : ViewComponent
    {
        private readonly IStringLocalizer<SharedResources> _localizer;

        private readonly IAppUserService _appuserservice;
        private readonly IMapper _mapper;

        public NavbarComponent(IStringLocalizer<SharedResources> localizer, IAppUserService appuserservice, IMapper mapper)
        {
            _localizer = localizer;
            _appuserservice = appuserservice;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            //ViewData["About"] = _localizer.GetString("About");
            //ViewData["Certification"] = _localizer.GetString("Certification");
            //ViewData["Education"] = _localizer.GetString("Education");
            //ViewData["Experience"] = _localizer.GetString("Experience");
            //ViewData["Interests"] = _localizer.GetString("Interests");
            //ViewData["Projects"] = _localizer.GetString("Projects");
            //ViewData["Skills"] = _localizer.GetString("Skills");

            return View(_mapper.Map<AppUserListDTO>(_appuserservice.GetAll()[0]));
        }
    }
}
