using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryReserveCancelLog : RepositoryBase<ReserveCancelLog>,IRepositoryReserveCancelLog
    {
        public RepositoryReserveCancelLog(IRepository repository) : base(repository)
        {
        }
    }
}
