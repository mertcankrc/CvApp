using CVApp.Bussiness.Interface;
using CVApp.DataAccess.Interface;
using CVApp.Entities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CVApp.Bussiness.Methods
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private IGenericRepo<TEntity> _genericRepo;

        public GenericManager(IGenericRepo<TEntity> genericRepo)
        {
            _genericRepo = genericRepo;
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                _genericRepo.Delete(entity);
                return true;
            }
            catch
            {
                return false;

            }
        }

        public List<TEntity> GetAll()
        {
            return _genericRepo.GetAll().ToList();
        }

        public TEntity GetById(int id)
        {
            return _genericRepo.GetById(id);
        }

        public bool Insert(TEntity entity)
        {
            try
            {
                _genericRepo.Insert(entity);
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
                _genericRepo.Update(entity);
                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
