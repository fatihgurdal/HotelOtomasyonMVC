using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class ExtraProductCategoriesModel
   {
      
        public int Id { get; set; }
       [DisplayName("Ekstra Ürün Kategori Adı")]
        public string Name { get; set; }
       public bool IsActive { get; set; }
        [DisplayName("Ekstra Ürünler")]
        public  ICollection<ExtraProducts> ExtraProducts { get; set; }
        [DisplayName("Paketlerdeki Ekstra Ürün Kategorileri")]
        public ICollection<PacketsExtraProductCategories> PacketsExtraProductCategories { get; set; }
    }
}
