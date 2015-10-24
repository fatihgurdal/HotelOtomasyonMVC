using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryPermits : RepositoryBase<Permits>,IRepositoryPermits
    {
        public RepositoryPermits(IRepository repository) : base(repository)
        {
        }
    }
}
