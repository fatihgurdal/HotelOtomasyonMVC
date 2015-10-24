using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class PacketsExtraProductCategories:IEntityKey<int>
    {
        public int Id { get; set; }
        public int PacketId { get; set; }
        public int ExtraProductCategoryId { get; set; }

        public bool IsActive { get; set; }

        public virtual ExtraProductCategories ExtraProductCategory { get; set; }

        public virtual Packets Packet { get; set; }
    }
}
