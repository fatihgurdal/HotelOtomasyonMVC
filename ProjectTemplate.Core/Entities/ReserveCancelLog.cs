using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class ReserveCancelLog:IEntityKey<int>
    {
        public int Id { get; set; }
        public DateTime ReserveDate { get; set; }
        public DateTime ReserveCancelDate { get; set; }

        public bool IsActive { get; set; }
        public string Description { get; set; }
        public Guid? AgencyId { get; set; }
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
       

    }
}
