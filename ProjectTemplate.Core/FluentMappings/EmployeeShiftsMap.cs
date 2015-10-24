using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
   public class EmployeeShiftsMap:EntityTypeConfiguration<EmployeeShifts>
   {
       public EmployeeShiftsMap()
       {
           HasKey(x => x.Id);
           Property(x => x.EmployeeId).IsRequired();
           Property(x => x.ShiftId).IsRequired();
       }
    }
}
