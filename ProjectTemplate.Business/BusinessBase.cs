using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessBase<TEntity> : IBusinessBase<TEntity> where TEntity : class, IEntityKey<int>, new()
    {
        private readonly IRepositoryBase<TEntity> _repository;
        protected readonly IUnitOfWork Uow;
        public BusinessBase(IRepositoryBase<TEntity> repository, IUnitOfWork uow)
        {
            _repository = repository;
            Uow = uow;
        }

        public int Insert(TEntity obj)
        {
            int r = 0;
            try
            {
                Uow.BeginTransaction();

                r= _repository.Insert(obj);

                Uow.Commit();
            }
            catch
            {
                Uow.Rollback();
            }
            return r;
        }
        public int Update(TEntity obj)
        {
            int r = 0;
            try
            {
                Uow.BeginTransaction();

                r=_repository.Update(obj);

                Uow.Commit();
            }
            catch(Exception ex)
            {
                Uow.Rollback();
            }
            return r;
        }

        public int Delete(TEntity obj)
        {
            int r = 0;
            try
            {
                Uow.BeginTransaction();

                r = _repository.Delete(obj);

                Uow.Commit();
            }
            catch(Exception ex)
            {
                Uow.Rollback();
            }
            return r;
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
