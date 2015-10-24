using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceRoomStatuses:ServiceBase<RoomStatuses>,IServiceRoomStatuses
    {
        private readonly IBusinessRoomStatuses _businessRoomStatuses;
        public ServiceRoomStatuses(IBusinessBase<RoomStatuses> business, IBusinessRoomStatuses businessRoomStatuses)
            : base(business)
        {
            _businessRoomStatuses = businessRoomStatuses;
        }
    }
}
