using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRoomFeatures : BusinessBase<RoomFeatures>,IBusinessRoomFeatures
    {
        public BusinessRoomFeatures(IRepositoryBase<RoomFeatures> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
