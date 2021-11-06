using CVApp.DataAccess.Interface;
using CVApp.Entities.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CVApp.DataAccess.Methods.Dapper
{
    public class DpDataAccess<TEntity> : IGenericRepo<TEntity> where TEntity: class,ITable,new()
    {

        private readonly IDbConnection _dbConn;

        public DpDataAccess(IDbConnection dbConn)
        {
            _dbConn = dbConn;
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                _dbConn.Delete(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<TEntity> GetAll()
        {
            return _dbConn.GetAll<TEntity>().ToList();
        }

      
        public TEntity GetById(int id)
        {
            return  _dbConn.Get<TEntity>(id);
        }

        public bool Insert(TEntity entity)
        {
            try
            {
                _dbConn.Insert(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                _dbConn.Update(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
