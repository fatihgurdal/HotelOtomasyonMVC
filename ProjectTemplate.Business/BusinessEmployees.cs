using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessEmployees : BusinessBase<Employees>,IBusinessEmployees
    {
        private readonly IRepositoryEmployees _repositoryEmployees;
        public BusinessEmployees(IRepositoryBase<Employees> repository, IUnitOfWork uow, IRepositoryEmployees repositoryEmployees)
            : base(repository, uow)
        {
            _repositoryEmployees = repositoryEmployees;
        }
    }
}
