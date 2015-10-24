using ProjectTemplate.Core.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjectTemplate.Core.FluentMappings
{
   public class CustomersMap:EntityTypeConfiguration<Customers>
    {
        public CustomersMap()
        {
            
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.Surname).IsRequired().HasMaxLength(50);
            Property(x => x.IsMale).IsRequired();
            Property(x => x.NationalityId).IsRequired();

            Property(x => x.DateOfBirth).IsRequired();
            Property(x => x.IdentificationNumber).IsRequired().HasMaxLength(11);
            Property(x => x.IsMarried).IsRequired();
            Property(x => x.PhoneNumber).IsRequired().HasMaxLength(13);
            Property(x => x.Address).IsRequired().HasMaxLength(200);
        }
    }
}
