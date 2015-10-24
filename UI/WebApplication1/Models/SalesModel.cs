using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class SalesModel
    {
        
        public int Id { get; set; }
        [DisplayName("Satış Mı")]
        public bool IsSale { get; set; }

        [DisplayName("Rezerve Tarihi"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Required]
        public DateTime ReserveDate { get; set; }

        [DisplayName("Ücret")]
        public decimal? Amount { get; set; }
        [DisplayName("Bilge Tour Komisyon")]
        public decimal? BilgeTourCommission { get; set; }
        [DisplayName("Acente Komisyon")]
        public decimal? AgenciesComission { get; set; }
        [DisplayName("Tahsil Edildi Mi?")]
        public bool IsCollect { get; set; }

        public bool IsActive { get; set; }

        [DisplayName("Müşteri Id")]
        [Required]
        public int CustomerId { get; set; }

        [DisplayName("Çalışan Id")]
        [Required]
        public int EmployeeId { get; set; }
        [DisplayName("Satış acente Id")]
        public Guid? SaleAgencyId { get; set; }
        public int? PaymentMethodId { get; set; }
        //Naviagtion property
        public  Customers Customer { get; set; }
        public  Employees Employee { get; set; }
        public  PaymentMethods PaymentMethod { get; set; }
        public  ICollection<RoomSales> RoomSales { get; set; }
    }
}
