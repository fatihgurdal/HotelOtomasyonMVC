using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class SalesMap:EntityTypeConfiguration<Sales>
    {
        public SalesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.CustomerId).IsRequired();
            Property(x => x.EmployeeId).IsRequired();
            Property(x => x.IsSale).IsRequired();
            
            Property(x => x.Amount).HasColumnType("decimal").HasPrecision(8, 2);
        }
    }
}
