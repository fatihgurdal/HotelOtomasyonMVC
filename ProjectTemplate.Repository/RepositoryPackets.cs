using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryPackets : RepositoryBase<Packets>,IRepositoryPackets
    {
        public RepositoryPackets(IRepository repository) : base(repository)
        {
        }
    }
}
