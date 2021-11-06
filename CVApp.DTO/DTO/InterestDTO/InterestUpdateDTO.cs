using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CVApp.DTO.DTO.InterestDTO
{
    public class InterestUpdateDTO : IDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen Hobi alanını boş geçmeyiniz")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Dili boş geçmeyiniz")]
        public string Language { get; set; }
    }
}
