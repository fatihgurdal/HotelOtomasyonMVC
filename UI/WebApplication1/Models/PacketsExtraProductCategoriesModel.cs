using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class PacketsExtraProductCategoriesModel
    {
        public int Id { get; set; }
       [DisplayName("Paket Id")]
        public int PacketId { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Ekstra Ürün Kategori Id")]
        public int ExtraProductCategoryId { get; set; }
       [DisplayName("Ekstra Ürün Kategori")]
        public  ExtraProductCategories ExtraProductCategory { get; set; }
       [DisplayName("Paket")]
        public  Packets Packet { get; set; }
    }
}
