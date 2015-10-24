using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceRoomFeatures : ServiceBase<RoomFeatures>,IServiceRoomFeatures
    {
        public ServiceRoomFeatures(IBusinessBase<RoomFeatures> business) : base(business)
        {
        }


    }
}
