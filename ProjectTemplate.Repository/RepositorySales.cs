using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositorySales : RepositoryBase<Sales>,IRepositorySales
   {
        public RepositorySales(IRepository repository) : base(repository)
        {
        }
   }
}
