using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.ExperienceDTO
{
    public class ExperienceAddDTO : IDTO
    {
        [Required(ErrorMessage ="Kurum adı boş geçilemez")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Ünvan boş geçilemez")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Açıklama boş geçilemez")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Başlangıç Tarihi boş geçilemez")]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }
    }
}
