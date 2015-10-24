using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class RoomFeaturesRoomTypesMap : EntityTypeConfiguration<RoomFeaturesRoomTypes>
    {
        public RoomFeaturesRoomTypesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.RoomFeatureId).IsRequired();
            Property(x => x.RoomFeatureQuantity).IsRequired();
            Property(x => x.RoomTypeId).IsRequired();
        }
    }
}
