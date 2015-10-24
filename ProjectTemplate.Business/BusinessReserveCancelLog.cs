using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
   public class BusinessReserveCancelLog:BusinessBase<ReserveCancelLog>,IBusinessReserveCancelLog
   {
       public BusinessReserveCancelLog(IRepositoryBase<ReserveCancelLog> repository, IUnitOfWork uow) : base(repository, uow)
       {
       }
   }
}
