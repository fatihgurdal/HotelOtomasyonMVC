using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class DiscountsMap:EntityTypeConfiguration<Discounts>
   {
       public DiscountsMap()
       {
           HasKey(x => x.Id);
           Property(x => x.Name).IsRequired().HasMaxLength(50);
           Property(x => x.StartingDate).IsRequired();
           //Property(x => x.EndingDate).IsRequired();
           Property(x => x.Rate).IsRequired();
           Property(x => x.IsActive).IsRequired();
           Property(x => x.Description).HasMaxLength(200);

       }
    }
}
