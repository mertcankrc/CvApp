using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.ProjectsDTO
{
    public class ProjectsAddDTO : IDTO
    {
        [Required(ErrorMessage ="Proje adını boş geçmeyiniz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Projeyi yaptığınız kurumu alanını boş geçmeyiniz")]
        public string SubTitle { get; set; }

        [Required(ErrorMessage = "Proje açıklamasını boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Başlangıç tarihini boş geçmeyiniz")]
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }
    }
}
