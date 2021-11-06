using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVApp.Web.Models
{
    public class AppUserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen ad alanını doldurunuz")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyad alanını doldurunuz")]

        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen Adres alanını doldurunuz")]

        public string Address { get; set; }
        [Required(ErrorMessage = "Lütfen Email alanını doldurunuz")]

        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon alanını doldurunuz")]
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Açıklama alanını doldurunuz")]
        public string ShortDescription { get; set; }

        public IFormFile Pic { get; set; }
        public string Language { get; set; }

    }
}
