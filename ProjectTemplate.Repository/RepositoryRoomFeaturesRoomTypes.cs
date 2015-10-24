using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryRoomFeaturesRoomTypes : RepositoryBase<RoomFeaturesRoomTypes>,IRepositoryRoomFeaturesRoomTypes
    {
        public RepositoryRoomFeaturesRoomTypes(IRepository repository) : base(repository)
        {
        }
    }
}
