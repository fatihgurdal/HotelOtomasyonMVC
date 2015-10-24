using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
   public class BusinessEmployeeShifts:BusinessBase<EmployeeShifts>,IBusinessEmployeeShifts
   {
       private readonly IRepositoryEmployeeShifts _repositoryEmployeeShifts;

       public BusinessEmployeeShifts(IRepositoryBase<EmployeeShifts> repository, IUnitOfWork uow,
           IRepositoryEmployeeShifts repositoryEmployeeShifts)
           : base(repository, uow)
       {
           _repositoryEmployeeShifts = repositoryEmployeeShifts;
       }
   }
}
