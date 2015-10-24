using System.Collections.Generic;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        //void Save(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        int Insert(TEntity obj);
        int Update(TEntity obj);
        int Delete(TEntity obj);
        void Dispose();
    }
}
