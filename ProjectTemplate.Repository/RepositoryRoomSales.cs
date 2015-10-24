using System;
using System.Collections.Generic;
using System.Linq;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryRoomSales : RepositoryBase<RoomSales>,IRepositoryRoomSales
    {
        public RepositoryRoomSales(IRepository repository) : base(repository)
        {
        }

        public IEnumerable<RoomSales> GetReserveRooms(DateTime nowDate)
        {
            return Repository.Select<RoomSales>().Where(x => x.LoginDate >= nowDate);
        }

        public IEnumerable<RoomSales> GetSaleRooms(int id)
        {
            return Repository.Select<RoomSales>().Where(x => x.SalesId == id);
        }
    }
}
