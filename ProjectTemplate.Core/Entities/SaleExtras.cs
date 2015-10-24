using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class SaleExtras:IEntityKey<int>
    {
        public int Id { get; set; }
        
        public int ProductUnit { get; set; }
        public decimal ProductAmount { get; set; }

        public bool IsActive { get; set; }

        public int RoomSaleId { get; set; }
        public int ExtraProductId { get; set; }
        //Nacigation Property
        public virtual RoomSales RoomSale { get; set; }
        public virtual ExtraProducts ExtraProduct { get; set; }
    }
}
