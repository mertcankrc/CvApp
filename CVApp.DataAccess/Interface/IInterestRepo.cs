using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface IInterestRepo : IGenericRepo<Interest>
    {
        public List<Interest> GetByLanguage(string language);

    }
}
