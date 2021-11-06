using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface ISkillService : IGenericService<Skill>
    {
        public List<Skill> GetByLanguage(string language);
    }
}
