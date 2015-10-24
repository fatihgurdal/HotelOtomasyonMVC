using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositorySaleExtras : RepositoryBase<SaleExtras>,IRepositorySaleExtras
   {
       
        public RepositorySaleExtras(IRepository repository) : base(repository)
        {
        }
   }
}
