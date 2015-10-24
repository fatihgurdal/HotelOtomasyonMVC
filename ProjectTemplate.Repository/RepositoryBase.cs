using System;
using System.Collections.Generic;
using System.Linq;
using ProjectTemplate.Core.Abstractions;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class, IEntityKey<int>, new()
    {
        protected readonly IRepository Repository;

        public RepositoryBase(IRepository repository)
        {
            Repository = repository;
        }

        public int Insert(TEntity obj)
        {
            return Repository.Insert(obj);
        }
        public int Update(TEntity obj)
        {
            return Repository.Update(obj);
        }
        public int Delete(TEntity obj)
        {
            return Repository.Delete(obj);
        }

        public TEntity GetById(int id)
        {
            return Repository.Select<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Repository.Select<TEntity>().ToList();
        }

        public void Dispose()
        {
          
        }
    }
}
