using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
  public  class RepositoryCustomers:RepositoryBase<Customers>, IRepositoryCustomers
    {
        public RepositoryCustomers(IRepository repository) : base(repository)
        {
        }
    }
}
