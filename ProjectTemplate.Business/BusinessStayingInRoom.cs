using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessStayingInRoom : BusinessBase<StayingInRoom>,IBusinessStayingInRoom
   {
        private readonly IRepositoryStayingInRoom _repositoryStayingInRoom;
        public BusinessStayingInRoom(IRepositoryBase<StayingInRoom> repository, IUnitOfWork uow, IRepositoryStayingInRoom repositoryStayingInRoom)
            : base(repository, uow)
        {
            _repositoryStayingInRoom = repositoryStayingInRoom;
        }
   }
}
