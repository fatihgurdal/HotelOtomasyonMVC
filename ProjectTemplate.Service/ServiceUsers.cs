using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceUsers:ServiceBase<Users>,IServiceUsers
   {
       public ServiceUsers(IBusinessBase<Users> business) : base(business)
       {
       }
   }
}
