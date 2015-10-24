using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryPacketsExtraProductCategories : RepositoryBase<PacketsExtraProductCategories>,IRepositoryPacketsExtraProductCategories
    {
        public RepositoryPacketsExtraProductCategories(IRepository repository) : base(repository)
        {
        }
    }
}
