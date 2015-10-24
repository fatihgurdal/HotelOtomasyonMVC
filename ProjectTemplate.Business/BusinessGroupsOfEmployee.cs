using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessGroupsOfEmployee:BusinessBase<GroupsOfEmployee>,IBusinessGroupsOfEmployee
    {
        private readonly IRepositoryGroupsOfEmployee _repositoryGroupsOfEmployee;
        public BusinessGroupsOfEmployee(IRepositoryBase<GroupsOfEmployee> repository, IUnitOfWork uow, IRepositoryGroupsOfEmployee repositoryGroupsOfEmployee)
            : base(repository, uow)
        {
            _repositoryGroupsOfEmployee = repositoryGroupsOfEmployee;
        }
    }
}
