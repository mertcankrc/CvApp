using CVApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVApp.Bussiness.Interface
{
    public interface IGenericService<TEntity> where TEntity:class,ITable,new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);

        bool Insert(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
