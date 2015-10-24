using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class RoomsModel
    {
        public int Id { get; set; }
       [DisplayName("Oda Numarası")]
        public string Number { get; set; }
       [DisplayName("Blok Kat Id")]
        public int BlockFloorId { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Oda Tip Id")]
        public int RoomTypeId { get; set; }
      
       [DisplayName("Blok Kat")]
        public  BlockFloors BlockFloor { get; set; }
       [DisplayName("Oda Tipi")]
        public  RoomTypes RoomType { get; set; }
       [DisplayName("Oda Durum")]
        public  ICollection<RoomStatuses> RoomStatuses { get; set; }
       [DisplayName("Oda Satışları")]
        public  ICollection<RoomSales> RoomSales { get; set; }
    }
}
