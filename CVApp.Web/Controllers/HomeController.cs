using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVApp.Bussiness.Interface;
using CVApp.Entities.Models.DataModels;
using CVApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace CVApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<SharedResources> _localizer;
        public HomeController(IStringLocalizer<SharedResources> localizer)
        {
            _localizer = localizer;
        }
        public IActionResult Index()
        {

            ViewData["About"] = _localizer.GetString("About");
            ViewData["Certification"] = _localizer.GetString("Certification");
            ViewData["Education"] = _localizer.GetString("Education");
            ViewData["Experience"] = _localizer.GetString("Experience");
            ViewData["Interests"] = _localizer.GetString("Interests");
            ViewData["Projects"] = _localizer.GetString("Projects");
            ViewData["Skills"] = _localizer.GetString("Skills");
            ViewData["Programming"] = _localizer.GetString("Programming");
            ViewData["Present"] = _localizer.GetString("Present");


            return View();
        }
    }
}