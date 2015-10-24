using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Statuses:IEntityKey<int>
    {
        public Statuses()
        {
            RoomStatuses=new HashSet<RoomStatuses>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }

        //Navigation Property
        public virtual ICollection<RoomStatuses> RoomStatuses { get; set; }
    }
}
