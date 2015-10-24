using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessRoomSales : IBusinessBase<RoomSales>
    {
        IEnumerable<RoomSales> GetReserveRooms(DateTime? nowDate = null);
        IEnumerable<RoomSales> GetSaleRooms(int id);
    }
}
