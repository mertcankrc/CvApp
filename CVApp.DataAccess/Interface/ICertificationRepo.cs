using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface ICertificationRepo : IGenericRepo<Certification>
    {
        public List<Certification> GetByLanguage(string language);

    }
}
