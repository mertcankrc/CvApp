using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Models
{
    public class AppUserUpdatePassword
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen eski şifreyi boş bırakmayınız")]
        public string OldPass { get; set; }
        [Required(ErrorMessage = "Yeni şifre boş geçilemez")]
        public string NewPass { get; set; }

        [Required(ErrorMessage = "Yeni şifre tekrarı boş geçilemez")]
        public string NewPassAgain { get; set; }

    }
}
