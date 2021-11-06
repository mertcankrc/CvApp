using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface ICertificationService : IGenericService<Certification>
    {
        public List<Certification> GetByLanguage(string language);
    }
}
