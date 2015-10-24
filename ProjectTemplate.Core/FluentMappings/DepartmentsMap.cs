using System.Data.Entity.ModelConfiguration;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.FluentMappings
{
  public  class DepartmentsMap:EntityTypeConfiguration<Departments>
  {
      public DepartmentsMap()
      {
          HasKey(x => x.Id);
          Property(x => x.Name).IsRequired().HasMaxLength(15);
      }
    }
}
