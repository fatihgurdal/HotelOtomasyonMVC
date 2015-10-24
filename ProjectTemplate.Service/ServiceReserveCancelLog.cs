using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceReserveCancelLog:ServiceBase<ReserveCancelLog>,IServiceReserveCancelLog
   {
       public ServiceReserveCancelLog(IBusinessBase<ReserveCancelLog> business) : base(business)
       {
       }
   }
}
