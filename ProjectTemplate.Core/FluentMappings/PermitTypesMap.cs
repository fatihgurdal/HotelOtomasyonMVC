using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class PermitTypesMap:EntityTypeConfiguration<PermitTypes>
   {
       public PermitTypesMap()
       {
           HasKey(x => x.Id);
           Property(x => x.Name).HasMaxLength(50).IsRequired();
           Property(x => x.IsPaid).IsRequired();
       }
    }
}
