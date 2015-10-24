using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class RoomFeatures:IEntityKey<int>
    {
       public RoomFeatures()
       {
           RoomFeaturesRoomTypes= new HashSet<RoomFeaturesRoomTypes>();
       }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<RoomFeaturesRoomTypes> RoomFeaturesRoomTypes { get; set; }
    }
}
