using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IEducationService : IGenericService<Education>
    {
        public List<Education> GetByLanguage(string language);

    }
}
