using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class EmployeeShifts:IEntityKey<int>
   {
       public int Id { get;set; }
       public decimal DailyWages { get; set; }
       public int ShiftId { get; set; }
       public int EmployeeId { get; set; }

       public bool IsActive { get; set; }
       public virtual Shifts Shift { get; set; }
       public virtual Employees Employee { get; set; }
   }
}
