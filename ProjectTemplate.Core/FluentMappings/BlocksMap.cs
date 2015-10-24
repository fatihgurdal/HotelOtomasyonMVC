using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class BlocksMap : EntityTypeConfiguration<Blocks>
    {
        public BlocksMap()
        {
            HasKey(x => x.Id);
            Property(x => x.BlockName).HasMaxLength(15).IsRequired();
        }
    }
}
