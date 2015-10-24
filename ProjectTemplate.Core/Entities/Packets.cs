using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Packets:IEntityKey<int>
    {
       public Packets()
       {
           PacketsExtraProductCategories= new HashSet<PacketsExtraProductCategories>();
           RoomSales= new HashSet<RoomSales>();
       }
        public int Id { get; set; }
        public string  Name { get; set; }
        public bool IsActive { get; set; }
        public int PricePercentage { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PacketsExtraProductCategories> PacketsExtraProductCategories { get; set; }
        public virtual ICollection<RoomSales> RoomSales { get; set; }
    }
}
