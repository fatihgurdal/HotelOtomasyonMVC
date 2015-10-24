using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class EmployeesMap:EntityTypeConfiguration<Employees>
    {
        public EmployeesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.RegistrationNumber).IsRequired();
            Property(x => x.Name).IsRequired().HasMaxLength(20);
            Property(x => x.Surname).IsRequired().HasMaxLength(20);
            Property(x => x.DateOfBirth).IsRequired();
            Property(x => x.PlaceOfBirth).IsRequired().HasMaxLength(30);
            Property(x => x.IsMale).IsRequired();
            Property(x => x.IsDelete).IsRequired();
            Property(x => x.BloodGroup).IsRequired().HasMaxLength(6);
            Property(x => x.PhoneNumber).HasMaxLength(14);
            Property(x => x.EmailAddress).IsRequired().HasMaxLength(50);
            Property(x => x.Address).IsRequired().HasMaxLength(200);
            Property(x => x.IsMonthlyWage).IsRequired();
            Property(x => x.Salary).IsRequired().HasColumnType("decimal").HasPrecision(10, 2);
            Property(x => x.DepartureDate);
            //Property(x => x.DateOfEntry).IsRequired();
            Property(x => x.Description).HasMaxLength(300);
        }
    }
}
