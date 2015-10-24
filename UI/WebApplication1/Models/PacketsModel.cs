using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class PacketsModel
    {
     
        public int Id { get; set; }
       [DisplayName("Paket Adı")]
        public string  Name { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Fiyat Oranı")]
        public int PricePercentage { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Paketlerin Ekstra Ürün Kategorileri")]
        public  ICollection<PacketsExtraProductCategories> PacketsExtraProductCategories { get; set; }
        [DisplayName("Oda Satışları")]
        public  ICollection<RoomSales> RoomSales { get; set; }
    }
}
