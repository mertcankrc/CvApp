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
    public class DpExperienceRepo : DpDataAccess<Experience>,IExperienceRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpExperienceRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        public List<Experience> GetByLanguage(string language)
        {
            return _dbConnection.Query<Experience>("select *  from Experiences " +
                 "where Language = @language Order by StartDate Desc", new { language }).ToList();
        }
    }
}
