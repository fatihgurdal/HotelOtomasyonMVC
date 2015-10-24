using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessExtraProductCategories:BusinessBase<ExtraProductCategories>,IBusinessExtraProductCategories
    {
        private readonly IRepositoryExtraProductCategories _repositoryExtraProductCategories;
        public BusinessExtraProductCategories(IRepositoryBase<ExtraProductCategories> repository, IUnitOfWork uow, IRepositoryExtraProductCategories repositoryExtraProductCategories)
            : base(repository, uow)
        {
            _repositoryExtraProductCategories = repositoryExtraProductCategories;
        }
    }
}
