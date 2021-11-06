using AutoMapper;
using CVApp.Bussiness.Interface;
using CVApp.DTO.DTO.AppUserDTO;
using CVApp.DTO.DTO.CertificationDTO;
using CVApp.DTO.DTO.EducationDTO;
using CVApp.Entities.Models.DataModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Views.Shared.Components.CertificationComponent
{
    public class CertificationComponent : MainComponent
    {

        private readonly ICertificationService _certificationService;
        private readonly IMapper _mapper;

        public CertificationComponent(ICertificationService certificationService, IMapper mapper)
        {
            _certificationService = certificationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
         
            return View(_mapper.Map<List<CertificationListDTO>>(_certificationService.GetByLanguage(GetCulture())));
        }

      
    }
}
