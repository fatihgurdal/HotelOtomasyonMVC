using System;
using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Shifts:IEntityKey<int>
    {
        public Shifts()
        {
            EmployeeShifts=new HashSet<EmployeeShifts>();
        }

        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public bool IsActive { get; set; }

        //Navigation property
        public virtual ICollection<EmployeeShifts> EmployeeShifts { get; set; }
    }
}
