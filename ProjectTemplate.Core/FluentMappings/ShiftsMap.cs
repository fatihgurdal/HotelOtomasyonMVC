using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class ShiftsMap:EntityTypeConfiguration<Shifts>
    {
        public ShiftsMap()
        {
            HasKey(x => x.Id);
            Property(x => x.StartTime).IsRequired();
                //.HasColumnType("time(7)");
            Property(x => x.EndTime).IsRequired();
                //.HasColumnType("time(7)");
        }
    }
}
