using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
  public  class RepositoryDiscounts:RepositoryBase<Discounts>,IRepositoryDiscounts
  {
      public RepositoryDiscounts(IRepository repository) : base(repository)
      {
      }
  }
}
