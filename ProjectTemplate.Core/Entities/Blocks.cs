using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
  public  class Blocks:IEntityKey<int>
  {
      public Blocks()
      {
          BlockFloors= new HashSet<BlockFloors>();
      }
        public int Id { get; set; }
        public string BlockName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<BlockFloors> BlockFloors { get; set; }
    }
}
