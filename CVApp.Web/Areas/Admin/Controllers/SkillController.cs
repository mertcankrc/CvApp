using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.SkillDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SkillController : Controller
    {
        private readonly IGenericService<Skill> _skillService;
        private readonly IMapper _mapper;

        public SkillController(IGenericService<Skill> skillService, IMapper mapper)
        {
            _skillService = skillService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<SkillListDTO>>(_skillService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var getDeleteDataModel = _skillService.GetById(id);
            _skillService.Delete(getDeleteDataModel);
            TempData["Message"] = "Yetenek başarıyla silindi";
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(SkillAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _skillService.Insert(_mapper.Map<Skill>(model));
                TempData["Message"] = "Yetenek başarıyla eklendi";
                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult Update(int id)
        {
            var getModel = _skillService.GetById(id);
            return View(_mapper.Map<SkillUpdateDTO>(getModel));
        }


        [HttpPost]
        public IActionResult Update(SkillUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var updatedModel = _skillService.GetById(model.Id);
                updatedModel.Description = model.Description;
                updatedModel.Language = model.Language;
                _skillService.Update(updatedModel);
                TempData["Message"] = "Yetenek Başarıyla Güncellendi";
                return RedirectToAction("Index");

            }
            return View(model);
        }

    }
}