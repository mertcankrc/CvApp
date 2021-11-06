using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface  IProjectsRepo : IGenericRepo<Projects>
    {
        public List<Projects> GetByLanguage(string language);
    }
}
