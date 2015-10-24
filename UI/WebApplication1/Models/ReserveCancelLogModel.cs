using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class ReserveCancelLogModel
    {
        public int Id { get; set; }
        [DisplayName("Rezerve Tarihi"), DataType(DataType.DateTime)]
        public DateTime ReserveDate { get; set; }
        [DisplayName("İptal Tarihi"), DataType(DataType.DateTime)]
        public DateTime ReserveCancelDate { get; set; }

        public bool IsActive { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Acente Id")]
        public Guid? AgencyId { get; set; }
        [DisplayName("Satış Id")]
        public int SaleId { get; set; }
        [DisplayName("Müşteri Id")]
        public int CustomerId { get; set; }
       

    }
}
