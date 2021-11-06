using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class SkillManager : GenericManager<Skill>, ISkillService
    {
        private readonly IGenericRepo<Skill> _genericRepo;
        private readonly ISkillsRepo _speceficRepo;
        public SkillManager(IGenericRepo<Skill> genericRepo, ISkillsRepo repo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _speceficRepo = repo;
        }
        public List<Skill> GetByLanguage(string language)
        {
            return _speceficRepo.GetByLanguage(language);
        }
    }
}
