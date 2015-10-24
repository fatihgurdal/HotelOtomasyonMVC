using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
  public  class RepositoryFloors:RepositoryBase<Floors>,IRepositoryFloors
  {
      public RepositoryFloors(IRepository repository) : base(repository)
      {
      }
  }
}
