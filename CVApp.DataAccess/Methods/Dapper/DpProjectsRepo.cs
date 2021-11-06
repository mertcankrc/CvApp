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
    public class DpProjectsRepo : DpDataAccess<Projects>, IProjectsRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpProjectsRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        
        public List<Projects> GetByLanguage(string language)
        {
            return _dbConnection.Query<Projects>("select *  from Projects " +
            "where Language = @language Order by StartDate Desc", new { language }).ToList();
            
        }
    }
}
