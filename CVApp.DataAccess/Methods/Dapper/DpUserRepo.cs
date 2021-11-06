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
    public class DpUserRepo : DpDataAccess<AppUser>,IAppUserRepo
    {
        private readonly IDbConnection _dbConnection;
        public DpUserRepo(IDbConnection dbConn) : base(dbConn)
        {
            _dbConnection = dbConn;
        }

        public bool CheckUser(string userName, string userPass)
        {
          var user =  _dbConnection.QueryFirstOrDefault<AppUser>("select *  from AppUsers " +
                "where UserName = @userName and Password = @Password",new { userName = userName,Password = userPass});
            return user != null;
        }

   

        public AppUser FindUserByUserName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select *  from AppUsers " +
                 "where UserName = @userName", new { userName = userName });
           
        }

        public AppUser GetByLanguage(string language)
        {
            return _dbConnection.Query<AppUser>("select *  from AppUsers " +
           "where Language = @language", new { language }).FirstOrDefault();
            
        }
    }
}
