using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class BlockFloorsMap:EntityTypeConfiguration<BlockFloors>
    {
        public BlockFloorsMap()
        {
            HasKey(x => x.Id);
            Property(x => x.BlockId).IsRequired();
            Property(x => x.FloorId).IsRequired();
        }
    }
}
