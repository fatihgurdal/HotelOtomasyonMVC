using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class RoomFeaturesMap : EntityTypeConfiguration<RoomFeatures>
    {
        public RoomFeaturesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50).IsRequired();
        }
    }
}
