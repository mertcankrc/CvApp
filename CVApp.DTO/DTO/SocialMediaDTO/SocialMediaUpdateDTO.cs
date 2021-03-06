using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.SocialMediaDTO
{
    public class SocialMediaUpdateDTO : IDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Link alanı boş geçilemez")]
        public string Link { get; set; }
        [Required(ErrorMessage = "Icon alanı boş geçilemez")]
        public string Icon { get; set; }
    }
}
