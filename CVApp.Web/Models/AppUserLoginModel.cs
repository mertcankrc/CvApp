using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Models
{
    public class AppUserLoginModel
    {
        [Required(ErrorMessage ="Kullanıcı adı gereklidir")]
        public string UserName {get;set;}

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string Pass { get; set; }

        public bool RememberMe { get; set; }

    }
}
