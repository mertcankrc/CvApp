using CVApp.DTO.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace CVApp.DTO.DTO.SkillDTO
{
    public class SkillUpdateDTO : IDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen yetenek alanını boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }
    }
}
