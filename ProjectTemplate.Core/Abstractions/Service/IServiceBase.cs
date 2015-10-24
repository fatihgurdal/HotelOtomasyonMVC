using System.Collections.Generic;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        int Insert(TEntity obj);
        int Update(TEntity obj);
        int Delete(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Dispose();
    }
}