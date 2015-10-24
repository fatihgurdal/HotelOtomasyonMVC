using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class RoomTypes:IEntityKey<int>
    {
        public RoomTypes()
        {
            RoomFeaturesRoomTypes=new HashSet<RoomFeaturesRoomTypes>();
            Rooms=new HashSet<Rooms>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public byte Quota { get; set; }

        public bool IsActive { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
        public virtual ICollection<RoomFeaturesRoomTypes> RoomFeaturesRoomTypes { get; set; }
    }
}
