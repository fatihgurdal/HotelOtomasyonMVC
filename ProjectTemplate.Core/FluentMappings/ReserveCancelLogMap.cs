using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class ReserveCancelLogMap : EntityTypeConfiguration<ReserveCancelLog>
   {
        public ReserveCancelLogMap()
        {
            HasKey(x => x.Id);
            //Property(x => x.ReserveCancelDate).IsRequired();
            //Property(x => x.ReserveDate).IsRequired();
            Property(x => x.CustomerId).IsRequired();
            Property(x => x.SaleId).IsRequired();
        }
    }
}
