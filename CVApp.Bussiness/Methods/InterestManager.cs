using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class InterestManager : GenericManager<Interest>, IInterestService
    {
        private readonly IGenericRepo<Interest> _genericRepo;
        private readonly IInterestRepo _speceficRepo;
        public InterestManager(IGenericRepo<Interest> genericRepo, IInterestRepo repo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _speceficRepo = repo;
        }

        public List<Interest> GetByLanguage(string language)
        {
            return _speceficRepo.GetByLanguage(language);
        }
    }
}
