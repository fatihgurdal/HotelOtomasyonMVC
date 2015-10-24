

using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class ExtraProductsModel
    {
     
        public int Id { get; set; }
         [DisplayName("Ekstra Ürün Adı")]
        public string Name { get; set; }

        [DisplayName("Ekstra Ürün Ücreti")]
        public decimal Amount { get; set; }

        [DisplayName("Aktif Mi?")]
        public bool IsActive { get; set; }

         [DisplayName("Ekstra Ürün Kategori Id")]
        public int ExtraProductCategoryId { get; set; }
        //Navigation property

         [DisplayName("Ekstra Ürün Kategori")]
        public  ExtraProductCategories ExtraProductCategory { get; set; }
         [DisplayName("Satış Ekstraları")]
        public  ICollection<SaleExtras> SaleExtras { get; set; }
    }
}
