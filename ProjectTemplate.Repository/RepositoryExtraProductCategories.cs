using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryExtraProductCategories : RepositoryBase<ExtraProductCategories>,IRepositoryExtraProductCategories
   {
        public RepositoryExtraProductCategories(IRepository repository) : base(repository)
        {
        }
   }
}
