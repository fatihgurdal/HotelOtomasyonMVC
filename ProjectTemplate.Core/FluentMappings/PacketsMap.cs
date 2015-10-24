using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class PacketsMap:EntityTypeConfiguration<Packets>
    {
        public PacketsMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(30);
            Property(x => x.PricePercentage).IsRequired();
            Property(x => x.Description).HasMaxLength(100);
        }
    }
}
