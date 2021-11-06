using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class ExperienceManager : GenericManager<Experience>, IExperienceService
    {
        private readonly IGenericRepo<Experience> _genericRepo;
        private readonly IExperienceRepo _speceficRepo;
        public ExperienceManager(IGenericRepo<Experience> genericRepo, IExperienceRepo repo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _speceficRepo = repo;
        }
        public List<Experience> GetByLanguage(string language)
        {
            return _speceficRepo.GetByLanguage(language);
        }
    }
}
