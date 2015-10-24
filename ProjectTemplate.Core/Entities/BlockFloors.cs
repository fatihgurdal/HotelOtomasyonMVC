using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class BlockFloors:IEntityKey<int>
    {
        public BlockFloors()
        {
            Rooms= new HashSet<Rooms>();
        }
        public int Id { get; set; }
        public int BlockId { get; set; }
        public int FloorId { get; set; }

        //Navigation Property
        public virtual Blocks Block { get; set; }
        public virtual Floors Floor { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
