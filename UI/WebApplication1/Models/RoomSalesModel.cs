using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class RoomSalesModel
    {
       
        public int Id { get; set; }

        [DisplayName("Giriş Tarihi"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime LoginDate { get; set; }

        public bool IsActive { get; set; }

        [DisplayName("Çıkış Tarihi"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime LogoutDate { get; set; }


        [DisplayName("Ücret")]
        [Required]
        public decimal Amount { get; set; }

        [DisplayName("İndirim Id")]
        [Required]
        public int DiscountsId { get; set; }

        [DisplayName("Satış Id")]
        [Required]
        public int SalesId { get; set; }

        [DisplayName("Paket Id")]
        [Required]
        public int PacketId { get; set; }
        [DisplayName("Oda Id")]
        [Required]
        public int RoomId { get; set; }

        [DisplayName("Satış")]
        public Sales Sale { get; set; }
        [DisplayName("Oda")]
        public Rooms Room { get; set; }
        [DisplayName("Paket")]
        public Packets Packet { get; set; }
        [DisplayName("İndirim")]
        public Discounts Discount { get; set; }
        [DisplayName("Odada Kalanlar")]
        public ICollection<StayingInRoom> StayingInRooms { get; set; }
        [DisplayName("Satış Extraları")]
        public ICollection<SaleExtras> SaleExtras { get; set; }
    }
}
