using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessCustomers:BusinessBase<Customers>,IBusinessCustomers
    {
        private readonly IRepositoryCustomers _repositoryCustomers;
        public BusinessCustomers(IRepositoryBase<Customers> repository, IUnitOfWork uow, IRepositoryCustomers repositoryCustomers)
            : base(repository, uow)
        {
            _repositoryCustomers = repositoryCustomers;
        }
    }
}
