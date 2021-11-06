using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface IExperienceRepo : IGenericRepo<Experience>
    {
        public List<Experience> GetByLanguage(string language);

    }
}
