using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.CertificationDTO
{
    public class CertificationUpdateDTO : IDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Açıklama boş geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Dil boş geçilemez")]
        public string Language { get; set; }

    }
}
