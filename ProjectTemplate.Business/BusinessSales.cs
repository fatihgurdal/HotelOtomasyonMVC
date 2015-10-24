using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessSales : BusinessBase<Sales>,IBusinessSales
    {
        private readonly IRepositorySales _repositorySales;
        public BusinessSales(IRepositoryBase<Sales> repository, IUnitOfWork uow, IRepositorySales repositorySales)
            : base(repository, uow)
        {
            _repositorySales = repositorySales;
        }
    }
}
