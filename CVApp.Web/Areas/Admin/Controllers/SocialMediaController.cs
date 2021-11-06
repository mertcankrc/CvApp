using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.SocialMediaDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        private readonly IGenericService<SocialMediaIcon> _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(IGenericService<SocialMediaIcon> socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<SocialMediaListDTO>>(_socialMediaService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var getDeleteDataModel = _socialMediaService.GetById(id);
            _socialMediaService.Delete(getDeleteDataModel);
            TempData["Message"] = "Sosyal Medya başarıyla silindi";
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(SocialMediaAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _socialMediaService.Insert(_mapper.Map<SocialMediaIcon>(model));
                TempData["Message"] = "Sosyal Medya başarıyla eklendi";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {

            return View(_mapper.Map<SocialMediaUpdateDTO>(_socialMediaService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(SocialMediaUpdateDTO model)
        {

            if (ModelState.IsValid)
            {
                var updatedModel = _socialMediaService.GetById(model.Id);
                updatedModel.Link = model.Link;
                updatedModel.Icon = model.Icon;
                _socialMediaService.Update(updatedModel);
                TempData["Message"] = "Sosyal Medya başarıyla güncellendi";
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}