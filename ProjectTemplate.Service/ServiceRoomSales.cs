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
    public class ServiceRoomSales:ServiceBase<RoomSales>,IServiceRoomSales
    {
        private readonly IBusinessRoomSales _businessRoomSaless;
        public ServiceRoomSales(IBusinessBase<RoomSales> business,IBusinessRoomSales businessRoomSales) : base(business)
        {
            _businessRoomSaless = businessRoomSales;
        }

        public IEnumerable<RoomSales> GetReserveRooms(DateTime? nowDate = null)
        {
            return _businessRoomSaless.GetReserveRooms(nowDate);
        }

        public IEnumerable<RoomSales> GetSaleRooms(int id)
        {
            return _businessRoomSaless.GetSaleRooms(id);
        }
    }
}
