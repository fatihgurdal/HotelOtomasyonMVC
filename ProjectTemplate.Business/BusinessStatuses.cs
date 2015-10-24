using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessStatuses : BusinessBase<Statuses>,IBusinessStatuses
   {
        private readonly IRepositoryStatuses _repositoryStatuses;
        public BusinessStatuses(IRepositoryBase<Statuses> repository, IUnitOfWork uow, IRepositoryStatuses repositoryStatuses)
            : base(repository, uow)
        {
            _repositoryStatuses = repositoryStatuses;
        }
   }
}
