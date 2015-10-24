using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class EmployeeShiftsModel
   {
       public int Id { get;set; }
       [DisplayName("Ücret")]
       public decimal DailyWages { get; set; }

       public bool IsActive { get; set; }

       [DisplayName("Vardiya Id")]
       public int ShiftId { get; set; }
       [DisplayName("Personel Id")]
       public int EmployeeId { get; set; }

       [DisplayName("Vardiya")]
       public  ShiftsModel Shift { get; set; }

       [DisplayName("Personel")]
       public  EmployeesModel Employee { get; set; }
   }
}
