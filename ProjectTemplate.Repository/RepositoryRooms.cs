using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryRooms : RepositoryBase<Rooms>,IRepositoryRooms
    {
        public RepositoryRooms(IRepository repository) : base(repository)
        {
        }

        public IEnumerable<Rooms> GetDateRooms(DateTime startDateTime, DateTime endDateTime, int thisId)
        {

            IEnumerable<Rooms> roomses = Repository.Select<Rooms>()
                .Where(x => 
                    (!x.RoomSales.Any(y =>
                        (startDateTime <= y.LoginDate && endDateTime >= y.LoginDate) || (startDateTime <= y.LogoutDate && endDateTime >= y.LogoutDate) || (startDateTime>y.LoginDate && endDateTime<y.LogoutDate) || (x.Id==thisId))));

           
            return roomses;
        }

        public IEnumerable<Rooms> GetTypeRooms(int typeId)
        {
            return Repository.Select<Rooms>().Where(x => x.RoomTypeId == typeId);
        }

        public IEnumerable<Rooms> GetTypeAndDateRooms(DateTime startDateTime, DateTime endDateTime, int typeId,int thisId)
        {
            IEnumerable<Rooms> rooms = GetDateRooms(startDateTime, endDateTime, thisId).ToList();
            IEnumerable<Rooms> rooms2 = GetTypeRooms(typeId).ToList();

            IEnumerable<Rooms> realRoomses = (
                from first in rooms
                join second in rooms2
                    on first.Id equals second.Id

                select first
                );
            return realRoomses;
        }
    }
}
