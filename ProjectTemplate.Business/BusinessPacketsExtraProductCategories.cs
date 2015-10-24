using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessPacketsExtraProductCategories : BusinessBase<PacketsExtraProductCategories>,IBusinessPacketsExtraProductCategories
    {
        public BusinessPacketsExtraProductCategories(IRepositoryBase<PacketsExtraProductCategories> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
