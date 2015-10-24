using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class RoomStatusesMap : EntityTypeConfiguration<RoomStatuses>
    {
        public RoomStatusesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.StatusId).IsRequired();
            Property(x => x.RoomId).IsRequired();
        }
    }
}
