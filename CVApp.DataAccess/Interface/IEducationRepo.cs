using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface IEducationRepo : IGenericRepo<Education>
    {
        public List<Education> GetByLanguage(string language);
    }
}
