using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessShifts : BusinessBase<Shifts>,IBusinessShifts
    {
     
        private readonly IRepositoryShifts _repositoryShifts;
        public BusinessShifts(IRepositoryBase<Shifts> repository, IUnitOfWork uow,IRepositoryShifts repositoryShifts) : base(repository, uow)
        {
            _repositoryShifts= repositoryShifts;
        }
    }
}
