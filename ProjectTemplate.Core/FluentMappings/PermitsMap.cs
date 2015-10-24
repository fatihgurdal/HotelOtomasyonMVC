using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class PermitsMap:EntityTypeConfiguration<Permits>
   {
       public PermitsMap()
       {
           HasKey(x => x.Id);
           Property(x => x.EmployeeId).IsRequired();
           Property(x => x.StartingDate).IsRequired();
           Property(x => x.PermitTypeId).IsRequired();
          
       }
    }
}
