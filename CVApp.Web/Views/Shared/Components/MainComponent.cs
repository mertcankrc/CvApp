using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components
{
    public abstract class MainComponent : ViewComponent
    {
        public string GetCulture()
        {
            string culture = HttpContext.Request.Query["culture"].ToString();
            if (String.IsNullOrEmpty(culture))
            {
                culture = "tr-TR";
            }
            return culture;
        }
    }
}
