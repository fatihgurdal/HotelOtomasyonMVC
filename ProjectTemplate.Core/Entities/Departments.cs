using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Departments:IEntityKey<int>
    {
       public Departments()
       {
           GroupsOfEmployee= new HashSet<GroupsOfEmployee>();
       }
        public int Id { get; set; }

        public bool IsActive { get; set; }
        public string Name { get; set; }
        public virtual ICollection<GroupsOfEmployee> GroupsOfEmployee { get; set; }
    }
}
