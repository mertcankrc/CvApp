using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IInterestService : IGenericService<Interest>
    {
        public List<Interest> GetByLanguage(string language);
    }
}
