using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Entities.Models
{
    public class ShortBaseModel
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }

    }
}
