using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Repository
{
    public class RepositoryRoomFeatures : RepositoryBase<RoomFeatures>,IRepositoryRoomFeatures
    {
        public RepositoryRoomFeatures(IRepository repository) : base(repository)
        {
        }
    }
}
