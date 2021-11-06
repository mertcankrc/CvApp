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
    public class DpCertificationRepo : DpDataAccess<Certification>, ICertificationRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpCertificationRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        public List<Certification> GetByLanguage(string language)
        {
            return  _dbConnection.Query<Certification>("select *  from Certifications " +
                 "where Language = @language", new { language }).ToList();
           
        }
    }
}
