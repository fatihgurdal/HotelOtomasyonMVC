using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class ShiftsModel
    {
        public int Id { get; set; }
        [DisplayName("Başlangıç Saati"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public TimeSpan StartTime { get; set; }

        [DisplayName("Bitiş Saati"), DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public TimeSpan EndTime { get; set; }

        public bool IsActive { get; set; }

        //Navigation property
        [DisplayName("Çalışan Vardiyaları")]
        public virtual ICollection<EmployeeShifts> EmployeeShifts { get; set; }

        
    }
}
