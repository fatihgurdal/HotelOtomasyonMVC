using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class UserAuthoritiesMap:EntityTypeConfiguration<UserAuthorities>
    {
        public UserAuthoritiesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.UserId).IsRequired();
            Property(x => x.AuthorityId).IsRequired();
        }
    }
}
