

using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
  public class StayingInRoomModel
    {
        public int Id { get; set; }
      [DisplayName("Satış Oda Id")]
        public int RoomSale_Id { get; set; }
      public bool IsActive { get; set; }
      [DisplayName("Müşteri Id")]
        public int CustomerId { get; set; }
      [DisplayName("Müşteri")]
        public virtual  Customers Customer { get; set; }
      [DisplayName("Satış Oda")]
        public virtual RoomSales RoomSale { get; set; }
    }
}
