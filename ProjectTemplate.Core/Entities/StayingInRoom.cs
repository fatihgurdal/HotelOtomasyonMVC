using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
  public class StayingInRoom:IEntityKey<int>
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int RoomSaleId { get; set; }
        public bool IsActive { get; set; }
        public virtual RoomSales RoomSale { get; set; }
        public virtual Customers Customer { get; set; }

        
        
    }
}
