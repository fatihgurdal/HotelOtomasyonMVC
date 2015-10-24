using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryBlockFloors : RepositoryBase<BlockFloors>,IRepositoryBlockFloors
    {
        public RepositoryBlockFloors(IRepository repository) : base(repository)
        {
        }
    }
}
