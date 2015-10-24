using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class UsersMap : EntityTypeConfiguration<Users>
    {
        public UsersMap()
        {
            HasKey(x => x.Id);
        }
    }
}
