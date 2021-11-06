using CVApp.DTO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DTO.DTO.AppUserDTO
{
    public class AppUserUpdatePassDTO : IDTO
    {
        public int Id { get; set; }
      
        public string Password { get; set; }
    }
}
