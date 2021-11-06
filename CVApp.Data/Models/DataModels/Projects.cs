using CVApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Entities.Models.DataModels
{
    [Table("Projects")]
    public class Projects : BaseModel,ITable
    {
    }
}
