using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRoomFeaturesRoomTypes : BusinessBase<RoomFeaturesRoomTypes>,IBusinessRoomFeaturesRoomTypes
   {
        public BusinessRoomFeaturesRoomTypes(IRepositoryBase<RoomFeaturesRoomTypes> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
   }
}
