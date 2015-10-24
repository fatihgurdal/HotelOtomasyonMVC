using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceDepartments:ServiceBase<Departments>,IServiceDepartments
   {
       public ServiceDepartments(IBusinessBase<Departments> business) : base(business)
       {
       }
   }
}
