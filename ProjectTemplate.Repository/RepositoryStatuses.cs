using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryStatuses : RepositoryBase<Statuses>,IRepositoryStatuses
    {
        public RepositoryStatuses(IRepository repository) : base(repository)
        {
        }
    }
}
