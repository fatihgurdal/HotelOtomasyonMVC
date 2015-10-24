using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceRoomFeaturesRoomTypes : ServiceBase<RoomFeaturesRoomTypes>,IServiceRoomFeaturesRoomTypes
    {
        public ServiceRoomFeaturesRoomTypes(IBusinessBase<RoomFeaturesRoomTypes> business) : base(business)
        {
        }
    }
}
