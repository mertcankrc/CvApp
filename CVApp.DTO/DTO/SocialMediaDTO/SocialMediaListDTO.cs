using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DTO.DTO.SocialMediaDTO
{
    public class SocialMediaListDTO : IDTO
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public string Language { get; set; }

    }
}
