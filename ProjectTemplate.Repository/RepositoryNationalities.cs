using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryNationalities : RepositoryBase<Nationalities>,IRepositoryNationalities
    {
        public RepositoryNationalities(IRepository repository) : base(repository)
        {
        }
    }
}
