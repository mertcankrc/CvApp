using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Methods
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        private readonly IGenericRepo<AppUser> _genericRepo;
        private readonly IAppUserRepo _appUserRepository;
        public AppUserManager(IGenericRepo<AppUser> genericRepo,IAppUserRepo userRepo) : base(genericRepo)
        {

            //menager sınıflarından dataaccess'teki repo'ya bağlanıyoruz
            _genericRepo = genericRepo;
            _appUserRepository = userRepo;
        }

        public bool CheckUser(string userName, string userPass)
        {
           return _appUserRepository.CheckUser(userName,userPass);
        }

        public AppUser FindUserByUserName(string userName)
        {
            return _appUserRepository.FindUserByUserName(userName);
        }

        public AppUser GetByLanguage(string language)
        {
            return _appUserRepository.GetByLanguage(language);
        }
    }
}
