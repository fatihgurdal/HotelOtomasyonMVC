using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryGroupsOfEmployee : RepositoryBase<GroupsOfEmployee>, IRepositoryGroupsOfEmployee
   {
        public RepositoryGroupsOfEmployee(IRepository repository) : base(repository)
        {
        }
   }
}
