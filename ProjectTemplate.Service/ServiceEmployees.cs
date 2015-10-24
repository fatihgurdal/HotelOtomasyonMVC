using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceEmployees:ServiceBase<Employees>,IServiceEmployees
   {
       private readonly IBusinessEmployees _businessEmployees;
       public ServiceEmployees(IBusinessBase<Employees> business, IBusinessEmployees businessEmployees)
           : base(business)
       {
           _businessEmployees = businessEmployees;
       }
   }
}
