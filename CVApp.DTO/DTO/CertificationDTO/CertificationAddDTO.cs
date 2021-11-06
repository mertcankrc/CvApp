using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.CertificationDTO
{
    public class CertificationAddDTO : IDTO
    {
        [Required(ErrorMessage ="Sertifika açıklaması boş geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dil boş geçilemez")]
        public string Language { get; set; }

    }
}
