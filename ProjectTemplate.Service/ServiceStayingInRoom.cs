using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceStayingInRoom : ServiceBase<StayingInRoom>,IServiceStayingInRoom
    {
        private readonly IBusinessStayingInRoom _businessStayingInRoom;
        public ServiceStayingInRoom(IBusinessBase<StayingInRoom> business, IBusinessStayingInRoom businessStayingInRoom)
            : base(business)
        {
            _businessStayingInRoom = businessStayingInRoom;
        }
    }
}
