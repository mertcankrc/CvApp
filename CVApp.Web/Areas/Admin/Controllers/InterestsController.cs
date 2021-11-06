using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.InterestDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class InterestsController : Controller
    {
        private readonly IGenericService<Interest> _interestService;
        private readonly IMapper _mapper;

        public InterestsController(IGenericService<Interest> interestService, IMapper mapper)
        {
            _interestService = interestService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            
            return View(_mapper.Map<List<InterestListDTO>>(_interestService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var getDeleteDataModel = _interestService.GetById(id);
            _interestService.Delete(getDeleteDataModel);
            TempData["Message"] = "İlgi alanı başarıyla silindi";
            return RedirectToAction("Index");
        }


        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(InterestAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _interestService.Insert(_mapper.Map<Interest>(model));
                TempData["Message"] = "Yeni ilgi alanı başarıyla eklendi";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            var getModel = _interestService.GetById(id);
            return View(_mapper.Map<InterestUpdateDTO>(getModel));
        }

        [HttpPost]
        public IActionResult Update(InterestUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var updatedModel = _interestService.GetById(model.Id);
                updatedModel.Description = model.Description;
                updatedModel.Language = model.Language;
                _interestService.Update(updatedModel);
                TempData["Message"] = "İlgi alanı başarıyla güncellendi";
                return RedirectToAction("Index");

            }
            return View(model);
        }


    }
}