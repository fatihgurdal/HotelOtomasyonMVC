using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class PermitsModel
   {
       
       public int Id { get; set; }
       [DisplayName("Başlangıç Tarihi"), DataType(DataType.Date)]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime StartingDate { get; set; }
       [DisplayName("Bitiş Tarihi"), DataType(DataType.Date)]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime EndDate { get; set; }
       public bool IsActive { get; set; } 
       [DisplayName("İzin Tip Id")]
        public int PermitTypeId { get; set; }
       [DisplayName("Personel Id")]
        public int EmployeeId { get; set; }
       [DisplayName("İzin Tipi")]
        public virtual PermitTypes PermitType { get; set; }
       [DisplayName("Çalışan")]
        public virtual Employees Employee { get; set; }

    }
}
