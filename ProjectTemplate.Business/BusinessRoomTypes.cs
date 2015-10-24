using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessRoomTypes : BusinessBase<RoomTypes>,IBusinessRoomTypes
   {
        public BusinessRoomTypes(IRepositoryBase<RoomTypes> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
   }
}
