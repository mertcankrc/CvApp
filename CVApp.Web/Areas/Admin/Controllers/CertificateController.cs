using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.CertificationDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CertificateController : Controller
    {
        private readonly IGenericService<Certification> _genericService;
        private readonly IMapper _mapper;

    

        public CertificateController(IGenericService<Certification> genericService, IMapper mapper) 
        {
            _genericService = genericService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(_mapper.Map<List<CertificationListDTO>>(_genericService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            var getData = _genericService.GetById(id);
            _genericService.Delete(getData);
            return RedirectToAction("index");
        }

        public IActionResult CreateCertificate()
        {
         
            return View();
        }

        [HttpPost]
        public IActionResult CreateCertificate(CertificationAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _genericService.Insert(_mapper.Map<Certification>(model));
                TempData["Message"] = "Sertifika Ekleme Başarılı";
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Update(int id)
        {
            var getModel = _genericService.GetById(id);
            return View(_mapper.Map<CertificationUpdateDTO>(getModel));
        }

        [HttpPost]
        public IActionResult Update(CertificationUpdateDTO model)
        {
            if (ModelState.IsValid)
            {
                var updatedModel = _genericService.GetById(model.Id);
                updatedModel.Description = model.Description;
                updatedModel.Language = model.Language;
                _genericService.Update(updatedModel);
                TempData["Message"] = "Sertifika Başarıyla Güncellendi";
                return RedirectToAction("Index");

            }
            return View(model);
        }
    }
}
