using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class CertificationManager : GenericManager<Certification>, ICertificationService
    {
        private readonly IGenericRepo<Certification> _genericRepo;
        private readonly ICertificationRepo _certificationRepo;
        public CertificationManager(IGenericRepo<Certification> genericRepo, ICertificationRepo certificationRepo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _certificationRepo = certificationRepo;
        }

        public List<Certification> GetByLanguage(string language)
        {
           return  _certificationRepo.GetByLanguage(language);
        }
    }
}
