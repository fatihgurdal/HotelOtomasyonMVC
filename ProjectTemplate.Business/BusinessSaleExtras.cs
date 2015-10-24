using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessSaleExtras : BusinessBase<SaleExtras>, IBusinessSaleExtras
   {
        private readonly IRepositorySaleExtras _repositorySaleExtras;
        public BusinessSaleExtras(IRepositoryBase<SaleExtras> repository, IUnitOfWork uow, IRepositorySaleExtras repositorySaleExtras)
            : base(repository, uow)
        {
            _repositorySaleExtras = repositorySaleExtras;
        }
   }
}
