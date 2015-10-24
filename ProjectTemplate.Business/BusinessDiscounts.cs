using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessDiscounts : BusinessBase<Discounts>,IBusinessDiscounts
   {
        private readonly IRepositoryDiscounts _repositoryDiscounts;
        public BusinessDiscounts(IRepositoryBase<Discounts> repository, IUnitOfWork uow, IRepositoryDiscounts repositoryDiscounts)
            : base(repository, uow)
        {
            _repositoryDiscounts = repositoryDiscounts;
        }
   }
}
