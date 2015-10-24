using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class PermitTypes:IEntityKey<int>
   {
       public PermitTypes()
       {
           Permits= new HashSet<Permits>();
       }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public string Description { get; set; }
        public bool IsPaid { get; set; }

        public virtual ICollection<Permits> Permits { get; set; }
    }
}
