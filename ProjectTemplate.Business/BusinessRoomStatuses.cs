using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRoomStatuses : BusinessBase<RoomStatuses>,IBusinessRoomStatuses
   {
        private readonly IRepositoryRoomStatuses _repositoryRoomStatuses;
        public BusinessRoomStatuses(IRepositoryBase<RoomStatuses> repository, IUnitOfWork uow, IRepositoryRoomStatuses repositoryRoomStatuses)
            : base(repository, uow)
        {
            _repositoryRoomStatuses = repositoryRoomStatuses;
        }
   }
}
