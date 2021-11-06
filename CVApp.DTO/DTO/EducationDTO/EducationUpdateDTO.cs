using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.EducationDTO
{
    public class EducationUpdateDTO : IDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Eğitim Alınan kurum alanını boş geçmeyiniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Eğitim Alınan bölüm alanını boş geçmeyiniz")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Eğitim açıklamasını boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Başlangıç tarihini boş geçmeyiniz")]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? GNO { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }

    }
}
