using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class RoomSales : IEntityKey<int>
    {
        public RoomSales()
        {
                StayingInRooms=new HashSet<StayingInRoom>();
                SaleExtras= new HashSet<SaleExtras>();
        }
        public int Id { get; set; }
       
        public DateTime LoginDate { get; set; }
        public DateTime LogoutDate { get; set; }
        public decimal Amount { get; set; }

        public bool IsActive { get; set; }

        public int DiscountsId { get; set; }
        public int SalesId { get; set; }
        public int PacketId { get; set; }
        public int RoomId { get; set; }

        public virtual Sales Sale { get; set; }
        public virtual Rooms Room { get; set; }
        public virtual Packets Packet { get; set; }
        public virtual Discounts Discount { get; set; }
        public virtual ICollection<StayingInRoom> StayingInRooms { get; set; }
        public virtual ICollection<SaleExtras> SaleExtras { get; set; }
    }
}
