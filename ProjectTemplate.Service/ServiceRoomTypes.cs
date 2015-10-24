using System.Security.AccessControl;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceRoomTypes:ServiceBase<RoomTypes>,IServiceRoomTypes
    {
        public ServiceRoomTypes(IBusinessBase<RoomTypes> business) : base(business)
        {
            
        }
    }
}
