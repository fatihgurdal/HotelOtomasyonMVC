using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class RoomStatuses:IEntityKey<int>
    {
        public int Id { get; set; }
        public int StatusId { get; set; }
        public int RoomId { get; set; }
        public bool IsActive { get; set; }

        //Navigation property
        public virtual Rooms Room { get; set; }
        public virtual Statuses Status { get; set; }
    }
}
