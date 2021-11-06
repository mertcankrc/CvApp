using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.Entities.Models.DataModels;
using CVApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly IAppUserService _userService;
        private readonly IMapper _mapper;

        public HomeController(IAppUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;

        }

        public IActionResult Index()
        {
            
            return View(_mapper.Map<List<AppUserListDTO>>(_userService.GetAll()));
        }

        public IActionResult Update(int id)
        {
            var model = _mapper.Map<AppUserUpdateDTO>(_userService.GetById(id));
            AppUserUpdateModel updateModel = new AppUserUpdateModel
            {
                Address = model.Address,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                PhoneNumber = model.PhoneNumber,
                ShortDescription = model.ShortDescription,
                UserName = model.UserName,
                ImageUrl = model.ImageUrl,
                Id = model.Id,
                Language = model.Language

            };
            return View(updateModel);
        }

        public IActionResult Create()
        {
            
            return View();
        }


        [HttpPost]
        public IActionResult Create(AppUserCreateModel model)
        {
            if (ModelState.IsValid)
            {

                if (model.Pic != null)
                {
                    string imgName = Guid.NewGuid() + Path.GetExtension(model.Pic.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;

                    var stream = new FileStream(path, FileMode.Create);
                    model.Pic.CopyTo(stream);
                    model.ImageUrl = imgName;
                }
                _userService.Insert(_mapper.Map<AppUser>(model));
                TempData["Message"] = "Kullanıcı başarıyla Eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(AppUserUpdateModel model)
        {
            if (ModelState.IsValid)
            {
                var updatedAppUser = _userService.GetById(model.Id);

                if (model.Pic != null)
                {
                    string imgName = Guid.NewGuid() + Path.GetExtension(model.Pic.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;
                    
                    var stream = new FileStream(path,FileMode.Create);
                    model.Pic.CopyTo(stream);
                    model.ImageUrl = imgName;
                }

                updatedAppUser.Address = model.Address;
                updatedAppUser.Email = model.Email;
                updatedAppUser.FirstName = model.FirstName;
                updatedAppUser.ImageUrl = model.ImageUrl;
                updatedAppUser.LastName = model.LastName;
                updatedAppUser.PhoneNumber = model.PhoneNumber;
                updatedAppUser.ShortDescription = model.ShortDescription;
                updatedAppUser.Language = model.Language;
                _userService.Update(updatedAppUser);
                TempData["Message"] = "Kullanıcı başarıyla güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}