using CVApp.DataAccess.Interface;
using CVApp.Entities.Models.DataModels;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CVApp.DataAccess.Methods.Dapper
{
    public class DpSkillsRepo : DpDataAccess<Skill>, ISkillsRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpSkillsRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }


        public List<Skill> GetByLanguage(string language)
        {
            return _dbConnection.Query<Skill>("select *  from Skills " +
            "where Language = @language", new { language }).ToList();
            
        }
    }
}
