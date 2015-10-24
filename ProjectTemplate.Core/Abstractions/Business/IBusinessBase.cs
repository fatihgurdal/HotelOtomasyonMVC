using System.Collections.Generic;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessBase<TEntity> where TEntity : class
    {
        int Insert(TEntity obj);
        int Update(TEntity obj);
        int Delete(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Dispose();
    }
}
