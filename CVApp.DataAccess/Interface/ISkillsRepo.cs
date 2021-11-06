using CVApp.Entities.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.DataAccess.Interface
{
    public interface ISkillsRepo : IGenericRepo<Skill>
    {
        public List<Skill> GetByLanguage(string language);
    }
}
