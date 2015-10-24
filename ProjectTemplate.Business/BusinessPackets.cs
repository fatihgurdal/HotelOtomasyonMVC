using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessPackets : BusinessBase<Packets>,IBusinessPackets
   {
        private readonly IRepositoryPackets _repositoryPackets;
        public BusinessPackets(IRepositoryBase<Packets> repository, IUnitOfWork uow, IRepositoryPackets repositoryPackets)
            : base(repository, uow)
        {
            _repositoryPackets = repositoryPackets;
        }
   }
}
