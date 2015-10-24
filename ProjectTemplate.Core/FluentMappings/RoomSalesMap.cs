using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class RoomSalesMap:EntityTypeConfiguration<RoomSales>
    {
        public RoomSalesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.SalesId).IsRequired();
            Property(x => x.RoomId).IsRequired();
            Property(x => x.LoginDate).IsRequired();
            //Property(x => x.LogoutDate).IsRequired();
            Property(x => x.IsActive).IsRequired();
            Property(x => x.PacketId).IsRequired();
            Property(x => x.Amount).IsRequired().HasPrecision(8, 2);

        }
    }
}
