using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DTO.DTO.EducationDTO
{
    public class EducationListDTO : IDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal GNO { get; set; }
        public string Language { get; set; }


    }
}
