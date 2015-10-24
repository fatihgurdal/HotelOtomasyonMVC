using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceEmployeeShifts:ServiceBase<EmployeeShifts>,IServiceEmployeeShifts
   {
       private readonly IBusinessEmployeeShifts _businessEmployeeShifts;
       public ServiceEmployeeShifts(IBusinessBase<EmployeeShifts> business,IBusinessEmployeeShifts businessEmployeeShifts) : base(business)
       {
           _businessEmployeeShifts = businessEmployeeShifts;
       }
   }
}
