using System.Data;
using System.Data.Common;
using System.Data.Entity;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Core.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        public EFUnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
            //_transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        private DbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = _dbContext.Database.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public void Commit()
        {
            if (_transaction == null )
            {
                return;
            }

            try
            {
                _transaction.Commit();
                _transaction.Dispose();
            }
            finally
            {
                _transaction = null;
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
        }

        internal DbTransaction GetDbTransaction()
        {
            return _transaction.UnderlyingTransaction;
        }
    }
}
