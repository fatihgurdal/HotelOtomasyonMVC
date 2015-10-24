using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryRoomStatuses : RepositoryBase<RoomStatuses>,IRepositoryRoomStatuses
   {
        public RepositoryRoomStatuses(IRepository repository) : base(repository)
        {
        }
   }
}
