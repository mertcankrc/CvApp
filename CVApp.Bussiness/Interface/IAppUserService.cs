using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        /// <summary>
        /// Eğer user var ise true döner, yok ise false döner
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPass"></param>
        /// <returns></returns>
        public bool CheckUser(string userName, string userPass);
        public AppUser FindUserByUserName(string userName);

        public AppUser GetByLanguage(string language);

    }
}
