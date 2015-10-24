using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class SaleExtrasMap:EntityTypeConfiguration<SaleExtras>
    {
        public SaleExtrasMap()
        {
            HasKey(x => x.Id);
            Property(x => x.RoomSaleId).IsRequired();
            Property(x => x.ExtraProductId).IsRequired();
            Property(x => x.ProductUnit).IsRequired();
            Property(x => x.ProductAmount).IsRequired().HasColumnType("decimal").HasPrecision(6, 2);
        }
    }
}
