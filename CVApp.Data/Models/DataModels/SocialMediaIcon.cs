using CVApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Entities.Models.DataModels
{
    [Table("SocialMediaIcons")]
    public class SocialMediaIcon : ITable
    {
        [Key]
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }

        public string Language { get; set; }
    }
}
