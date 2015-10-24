using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
   public class BusinessPermits:BusinessBase<Permits>,IBusinessPermits
   {
       public BusinessPermits(IRepositoryBase<Permits> repository, IUnitOfWork uow) : base(repository, uow)
       {
       }
   }
}
