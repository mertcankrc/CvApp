using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.SkillDTO
{
    public class SkillAddDTO : IDTO
    {
        [Required(ErrorMessage = "Lütfen yetenek alanını boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }
    }
}
