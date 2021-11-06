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
    public class DpEducationRepo : DpDataAccess<Education>, IEducationRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpEducationRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        public List<Education> GetByLanguage(string language)
        {
            return _dbConnection.Query<Education>("select *  from Educations " +
                 "where Language = @language Order by StartDate Desc", new { language }).ToList();
        }
    }
}
