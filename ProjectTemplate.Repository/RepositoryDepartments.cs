using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryDepartments : RepositoryBase<Departments>,IRepositoryDepartments
    {
        public RepositoryDepartments(IRepository repository) : base(repository)
        {
        }
    }
}
