using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceFloors:ServiceBase<Floors>,IServiceFloors
   {
       public ServiceFloors(IBusinessBase<Floors> business) : base(business)
       {
       }
   }
}
