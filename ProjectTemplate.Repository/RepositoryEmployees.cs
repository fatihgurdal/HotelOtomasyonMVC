using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryEmployees:RepositoryBase<Employees>,IRepositoryEmployees
   {
       public RepositoryEmployees(IRepository repository) : base(repository)
       {
       }
   }
}
