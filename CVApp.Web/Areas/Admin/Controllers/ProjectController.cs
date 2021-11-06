using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.ProjectsDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CVApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProjectController : Controller
    {
        private readonly IGenericService<Projects> _projectService;
        private readonly IMapper _mapper;

        public ProjectController(IGenericService<Projects> projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

      

        public IActionResult Index()
        {
            var getData = _projectService.GetAll();
            return View(_mapper.Map<List<ProjectsListDTO>>(getData));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProjectsAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _projectService.Insert(_mapper.Map<Projects>(model));
                TempData["Message"] = "Yeni Proje Bilgisi Başarıyla Eklendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {

            var getData = _projectService.GetById(id);
            _projectService.Delete(getData);
            TempData["Message"] = "Proje Bilgisi Başarıyla Silindi";
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {

            var getData = _projectService.GetById(id);

            return View(_mapper.Map<ProjectsUpdateDTO>(getData));
        }

        [HttpPost]
        public IActionResult Update(ProjectsUpdateDTO model)
        {

            if (ModelState.IsValid)
            {
                var getDataModel = _projectService.GetById(model.Id);

                getDataModel.StartDate = model.StartDate;
                getDataModel.EndDate = model.EndDate;
                getDataModel.Title = model.Title;
                getDataModel.SubTitle = model.SubTitle;
                getDataModel.Description = model.Description;
                getDataModel.Language = model.Language;
                _projectService.Update(getDataModel);
                TempData["Message"] = "Proje Bilgisi Başarıyla Güncellendi";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}