using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.DTO.DTO.ExperienceDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
        private readonly IGenericService<Experience> _experienceService;
        private readonly IMapper _mapper;

        public ExperienceController(IGenericService<Experience> experienceService, IMapper mapper)
        {
            _experienceService = experienceService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {

            return View(_mapper.Map<List<ExperienceListDTO>>(_experienceService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var getDeleteDataModel = _experienceService.GetById(id);
            _experienceService.Delete(getDeleteDataModel);
            TempData["Message"] = "Tecrübe başarıyla silindi";
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExperienceAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _experienceService.Insert(_mapper.Map<Experience>(model));
                TempData["Message"] = "Yeni tecrübe başarıyla eklendi";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ExperienceUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var getUpdateModel = _experienceService.GetById(model.Id);
                getUpdateModel.Description = model.Description;
                getUpdateModel.EndDate = model.EndDate;
                getUpdateModel.StartDate = model.StartDate;
                getUpdateModel.SubTitle = model.SubTitle;
                getUpdateModel.Title = model.Title;
                getUpdateModel.Language = model.Language;

                _experienceService.Update(getUpdateModel);
                TempData["Message"] = "Tecrübe başarıyla güncellendi";
                return RedirectToAction("Index");


            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            return View(_mapper.Map<ExperienceUpdateDTO>(_experienceService.GetById(id)));
        }
    }
}