using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class StayingInRoomMap:EntityTypeConfiguration<StayingInRoom>
    {
        public StayingInRoomMap()
        {
            HasKey(x => x.Id);

            Property(x => x.CustomerId).IsRequired();
            Ignore(x => x.RoomSaleId);
            
        }
    }
}
