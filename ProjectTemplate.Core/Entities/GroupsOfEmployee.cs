using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
  public  class GroupsOfEmployee:IEntityKey<int>
  {
      public GroupsOfEmployee()
      {
          Employees= new HashSet<Employees>();
      }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int DepartmentId { get; set; }
        public virtual Departments Department { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
    }
}
