using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;

namespace ProjectTemplate.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class, IEntityKey<int>, new()
    {
        private readonly IBusinessBase<TEntity> _business;

        public ServiceBase(IBusinessBase<TEntity> business)
        {
            _business = business;
        }

        public int Insert(TEntity obj)
        {
            return _business.Insert(obj);
        }
        public int Update(TEntity obj)
        {
            return _business.Update(obj);
        }

        public int Delete(TEntity obj)
        {
            return _business.Delete(obj);
        }

        public TEntity GetById(int id)
        {
            return _business.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _business.GetAll();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
