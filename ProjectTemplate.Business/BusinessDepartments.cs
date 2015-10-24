using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessDepartments : BusinessBase<Departments>,IBusinessDepartments
    {
        public BusinessDepartments(IRepositoryBase<Departments> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
