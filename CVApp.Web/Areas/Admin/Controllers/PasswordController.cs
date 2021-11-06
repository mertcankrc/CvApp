using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CVApp.Bussiness.Interface;
using CVApp.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class PasswordController : Controller
    {
        private readonly IAppUserService _appuserservice;

        public PasswordController(IAppUserService appuserservice)
        {
            _appuserservice = appuserservice;
        }

        public IActionResult Change()
        {
            AppUserUpdatePassword pass = new AppUserUpdatePassword
            {
                Id = _appuserservice.FindUserByUserName(User.Identity.Name).Id


            };
            return View(pass);
        }

        [HttpPost]
        public async Task<IActionResult> Change(AppUserUpdatePassword model)
        {
            if(ModelState.IsValid)
            {
                var userInfo = _appuserservice.GetById(model.Id);

                var passControlResult = ControlPass(userInfo.Password, model.NewPass, model.NewPassAgain, model.OldPass);
                if (String.IsNullOrWhiteSpace(passControlResult))
                {
                    userInfo.Password = model.NewPass;
                    _appuserservice.Update(userInfo);
                    await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                    return RedirectToAction("index", "home", new { @area = "Admin" });

                }
                else
                {
                    ModelState.AddModelError("", passControlResult);
                }
            }
            return View(model);
        }

        private string ControlPass(string currentPassword, string newPass, string newPassAgain, string oldPass)
        {
            if(currentPassword!=oldPass)
            {
                return "Eski şifre yanlış";
            }
            else if(newPass!=newPassAgain)
            {
                return "Yeni şifre ve yeni şifre (tekrar) uyuşmuyor";
            }
            return "";
        }
    }
}