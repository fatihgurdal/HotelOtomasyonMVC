using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class ExtraProductsMap:EntityTypeConfiguration<ExtraProducts>
    {
        public ExtraProductsMap()
        {
            HasKey(x => x.Id);
            Property(x => x.ExtraProductCategoryId).IsRequired();
            Property(x => x.Name).IsRequired().HasMaxLength(30);
            Property(x => x.Amount).IsRequired().HasColumnType("decimal").HasPrecision(6, 2);
            Property(x => x.IsActive).IsRequired();

        }
    }
}
