using System;

namespace ProjectTemplate.Core.Repository
{
    /// <summary>
    /// The unitOfWork interface
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Opens database connection and begins transaction.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Commits active transaction
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollbacks active transaction
        /// </summary>
        void Rollback();
    }
}