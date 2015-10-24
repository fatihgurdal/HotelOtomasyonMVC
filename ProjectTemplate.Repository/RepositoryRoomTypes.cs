using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryRoomTypes : RepositoryBase<RoomTypes>,IRepositoryRoomTypes
   {
        public RepositoryRoomTypes(IRepository repository) : base(repository)
        {
        }
   }
}
