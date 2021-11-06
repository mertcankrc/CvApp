using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IExperienceService : IGenericService<Experience>
    {
        public List<Experience> GetByLanguage(string language);

    }
}
