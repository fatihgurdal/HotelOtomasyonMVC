using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class ExtraProductCategories:IEntityKey<int>
   {
       public ExtraProductCategories()
       {
           ExtraProducts= new HashSet<ExtraProducts>();
           PacketsExtraProductCategories= new HashSet<PacketsExtraProductCategories>();
       }
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsActive { get; set; }
        public virtual ICollection<ExtraProducts> ExtraProducts { get; set; }
        public virtual ICollection<PacketsExtraProductCategories> PacketsExtraProductCategories { get; set; }
    }
}
