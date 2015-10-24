using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class PacketsExtraProductCategoriesMap : EntityTypeConfiguration<PacketsExtraProductCategories>
    {
        public PacketsExtraProductCategoriesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.ExtraProductCategoryId).IsRequired();
            Property(x => x.PacketId).IsRequired();
        }
    }
}
