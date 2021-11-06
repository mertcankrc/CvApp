using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class EducationController : Controller
    {

        private readonly IGenericService<Education> _educationService;
        private readonly IMapper _mapper;

        public EducationController(IGenericService<Education> educationService, IMapper mapper)
        {
            _educationService = educationService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var getData = _educationService.GetAll();
            return View(_mapper.Map<List<EducationListDTO>>(getData));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EducationAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _educationService.Insert(_mapper.Map<Education>(model));
                TempData["Message"] = "Yeni Eğitim Bilgisi Başarıyla Eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {

            var getData = _educationService.GetById(id);
            _educationService.Delete(getData);
            TempData["Message"] = "Eğitim Bilgisi Başarıyla Silindi";
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {

            var getData = _educationService.GetById(id);

            return View(_mapper.Map<EducationUpdateDTO>(getData));
        }

        [HttpPost]
        public IActionResult Update(EducationUpdateDTO model)
        {

            if (ModelState.IsValid)
            {
                var getDataModel = _educationService.GetById(model.Id);

                getDataModel.GNO = model.GNO;
                getDataModel.StartDate = model.StartDate;
                getDataModel.EndDate = model.EndDate;
                getDataModel.Title = model.Title;
                getDataModel.SubTitle = model.SubTitle;
                getDataModel.Description = model.Description;
                getDataModel.Language = model.Language;

                _educationService.Update(getDataModel);
                TempData["Message"] = "Eğitim Bilgisi Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}