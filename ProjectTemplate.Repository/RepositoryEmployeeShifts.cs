using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryEmployeeShifts:RepositoryBase<EmployeeShifts>,IRepositoryEmployeeShifts
   {
       public RepositoryEmployeeShifts(IRepository repository) : base(repository)
       {
       }
   }
}
