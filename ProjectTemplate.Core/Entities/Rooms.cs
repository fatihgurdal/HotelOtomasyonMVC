using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Rooms:IEntityKey<int>
    {
       public Rooms()
       {
           RoomSales= new HashSet<RoomSales>();
           RoomStatuses = new HashSet<RoomStatuses>();
       }
        public int Id { get; set; }
        public string Number { get; set; }
        public bool IsActive { get; set; }
        public int BlockFloorId { get; set; }
        public int RoomTypeId { get; set; }

        public virtual BlockFloors BlockFloor { get; set; }
        public virtual RoomTypes RoomType { get; set; }
        public virtual ICollection<RoomStatuses> RoomStatuses { get; set; }

        public virtual ICollection<RoomSales> RoomSales { get; set; }
    }
}
