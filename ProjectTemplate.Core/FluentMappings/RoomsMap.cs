using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class RoomsMap:EntityTypeConfiguration<Rooms>
    {
        public RoomsMap()
        {
            HasKey(x => x.Id);
            Property(x => x.BlockFloorId).IsRequired();
            Property(x => x.RoomTypeId).IsRequired();
            Property(x => x.Number).IsRequired().HasMaxLength(5);
        }
    }
}
