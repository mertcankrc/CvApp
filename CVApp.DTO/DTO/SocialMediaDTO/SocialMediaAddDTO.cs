using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.SocialMediaDTO
{
    public class SocialMediaAddDTO : IDTO
    {
        [Required(ErrorMessage ="Link alanı boş geçilemez")]
        public string Link { get; set; }
        [Required(ErrorMessage = "Icon alanı boş geçilemez")]
        public string Icon { get; set; }
    }
}
