using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
   public class ServiceBlocks:ServiceBase<Blocks>,IServiceBlocks
   {
       public ServiceBlocks(IBusinessBase<Blocks> business) : base(business)
       {
       }
   }
}
