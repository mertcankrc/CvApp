using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class EducationManager : GenericManager<Education>, IEducationService
    {
        private readonly IGenericRepo<Education> _genericRepo;
        private readonly IEducationRepo _speceficRepo;
        public EducationManager(IGenericRepo<Education> genericRepo, IEducationRepo repo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _speceficRepo = repo;
        }

        public List<Education> GetByLanguage(string language)
        {
           return _speceficRepo.GetByLanguage(language);
        }
    }
}
