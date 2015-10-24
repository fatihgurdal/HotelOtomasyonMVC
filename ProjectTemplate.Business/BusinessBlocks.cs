using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
   public class BusinessBlocks:BusinessBase<Blocks>,IBusinessBlocks
    {
        public BusinessBlocks(IRepositoryBase<Blocks> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
