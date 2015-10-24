using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServicePermits:ServiceBase<Permits>,IServicePermits
   {
       public ServicePermits(IBusinessBase<Permits> business) : base(business)
       {
       }
   }
}
