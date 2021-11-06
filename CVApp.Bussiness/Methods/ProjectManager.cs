using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class ProjectManager : GenericManager<Projects>, IProjectService
    {
        private readonly IGenericRepo<Projects> _genericRepo;
        private readonly IProjectsRepo _speceficRepo;
        public ProjectManager(IGenericRepo<Projects> genericRepo, IProjectsRepo repo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _speceficRepo = repo;
        }
        public List<Projects> GetByLanguage(string language)
        {
            return _speceficRepo.GetByLanguage(language);
        }
    }
}
