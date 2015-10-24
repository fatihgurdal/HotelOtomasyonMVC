using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Discounts:IEntityKey<int>
    {
       public Discounts()
       {
           RoomSales= new HashSet<RoomSales>();
       }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public DateTime StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public int Rate { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RoomSales> RoomSales { get; set; }
    }
}
