using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class NationalitiesMap:EntityTypeConfiguration<Nationalities>
    {
        public NationalitiesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(5);
            Property(x => x.CountryName).IsRequired().HasMaxLength(30);

        }
    }
}
