using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class ExtraProducts:IEntityKey<int>
    {
        public ExtraProducts()
        {
                SaleExtras=new HashSet<SaleExtras>();
        }
        public int Id { get; set; }
        
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }

        public int ExtraProductCategoryId { get; set; }
        //Navigation property
        public virtual ExtraProductCategories ExtraProductCategory { get; set; }
        public virtual ICollection<SaleExtras> SaleExtras { get; set; }
    }
}
