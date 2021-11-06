using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DTO.DTO.CertificationDTO
{
    public class CertificationListDTO : IDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

    }
}
