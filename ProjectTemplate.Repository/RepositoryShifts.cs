using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryShifts : RepositoryBase<Shifts>,IRepositoryShifts
    {
        public RepositoryShifts(IRepository repository) : base(repository)
        {
        }
    }
}
