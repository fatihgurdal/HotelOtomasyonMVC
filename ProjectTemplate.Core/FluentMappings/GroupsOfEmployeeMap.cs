using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
    public class GroupsOfEmployeeMap : EntityTypeConfiguration<GroupsOfEmployee>
   {
        public GroupsOfEmployeeMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Name).HasMaxLength(50);
            Property(x => x.DepartmentId).IsRequired();
           
        }
    }
}
