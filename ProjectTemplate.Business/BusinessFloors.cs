using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessFloors:BusinessBase<Floors>,IBusinessFloors
    {
        public BusinessFloors(IRepositoryBase<Floors> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
