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
    public class DpInterestRepo : DpDataAccess<Interest>,IInterestRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpInterestRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        public List<Interest> GetByLanguage(string language)
        {
            return _dbConnection.Query<Interest>("select *  from Interests " +
             "where Language = @language", new { language }).ToList();
            
        }
    }
}
