using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessBlockFloors : BusinessBase<BlockFloors>,IBusinessBlockFloors
    {
        public BusinessBlockFloors(IRepositoryBase<BlockFloors> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
