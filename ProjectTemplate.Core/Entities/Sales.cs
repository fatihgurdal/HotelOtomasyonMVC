using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Sales : IEntityKey<int>
    {
        public Sales()
        {
            RoomSales=new HashSet<RoomSales>();
        }
        public int Id { get; set; }
        
        public bool IsSale { get; set; }
        public DateTime? ReserveDate { get; set; }
        public decimal? Amount { get; set; }
        public bool IsCollect { get; set; }
        public decimal? BilgeTourCommission { get; set; }
        public decimal? AgenciesComission { get; set; }
        public bool IsActive { get; set; }
        public Guid? SaleAgencyId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

        public int? PaymentMethodId { get; set; }
        //Naviagtion property
        public virtual Customers Customer { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual PaymentMethods PaymentMethod { get; set; }
        public virtual ICollection<RoomSales> RoomSales { get; set; }
    }
}
