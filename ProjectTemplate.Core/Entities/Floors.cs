using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Floors:IEntityKey<int>
   {
       public Floors()
       {
           BlockFloors= new HashSet<BlockFloors>();
       }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<BlockFloors> BlockFloors { get; set; }
    }
}
