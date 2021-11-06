using CVApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Entities.Models.DataModels
{
    [Table("Educations")]
    public class Education : BaseModel,ITable
    {
        public decimal? GNO { get; set; }
    }
}
