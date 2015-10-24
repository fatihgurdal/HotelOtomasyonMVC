using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class PaymentMethods:IEntityKey<int>
    {
        public PaymentMethods()
        {
            Sales=new HashSet<Sales>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
   
        public bool IsActive { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
