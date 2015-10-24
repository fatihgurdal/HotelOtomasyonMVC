

using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class SaleExtrasModel
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adeti")]
        public int ProductUnit { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal ProductAmount { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Satış Oda Id")]
        public int RoomSaleId { get; set; }
        [DisplayName("Extra Ürün Id")]
        public int ExtraProductId { get; set; }
        //Nacigation Property
        [DisplayName("Satış Oda")]
        public virtual RoomSales RoomSale { get; set; }
        [DisplayName("Extra Ürün")]
        public virtual ExtraProducts ExtraProduct { get; set; }
    }
}
