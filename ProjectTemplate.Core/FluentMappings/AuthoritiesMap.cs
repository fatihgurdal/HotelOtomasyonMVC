using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class AuthoritiesMap:EntityTypeConfiguration<Authorities>
    {
        public AuthoritiesMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(50);
            Property(x => x.ActionName)
                //.IsRequired()
                .HasMaxLength(50);
            Property(x => x.ControllerName)
                //.IsRequired()
                .HasMaxLength(50);
            Property(x => x.FaIconCode)
                //.IsRequired()
                .HasMaxLength(50);
        }
    }
}
