using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IProjectService : IGenericService<Projects>
    {
        public List<Projects> GetByLanguage(string language);
    }
}
