using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class HotelFeaturesMap:EntityTypeConfiguration<HotelFeatures>
   {
       public HotelFeaturesMap()
       {
           HasKey(x => x.Id);
           Property(x => x.Name).IsRequired().HasMaxLength(50);
       }
   }
}
