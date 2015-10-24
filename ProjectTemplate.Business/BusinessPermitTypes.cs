using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
   public class BusinessPermitTypes:BusinessBase<PermitTypes>,IBusinessPermitTypes
   {
       public BusinessPermitTypes(IRepositoryBase<PermitTypes> repository, IUnitOfWork uow) : base(repository, uow)
       {
       }
   }
}
