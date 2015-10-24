using System;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Permits:IEntityKey<int>
   {
        public int Id { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public int PermitTypeId { get; set; }
        public int EmployeeId { get; set; }
        public virtual PermitTypes PermitType { get; set; }
        public virtual Employees Employee { get; set; }

    }
}
