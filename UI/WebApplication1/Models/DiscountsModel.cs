using System;
using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
   public class DiscountsModel
    {
      
        public int Id { get; set; }

       [DisplayName("İndirim Adı")]
       [Required]
        public string Name { get; set; }
       [DisplayName("İndirim Başlama Tarihi")]
       [Required]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime StartingDate { get; set; }
       [DisplayName("İndirim Bitiş Tarihi")]
       [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? EndingDate { get; set; }

       [DisplayName("İndirim Oranı")]
       [Required]
        public int Rate { get; set; }
       [DisplayName("Aktif Mi?")]
       [Required]
        public bool IsActive { get; set; }
       [DisplayName("Açıklama")]
        public string Description { get; set; }
       [DisplayName("Oda Satışları")]
        public  ICollection<RoomSales> RoomSales { get; set; }
    }
}
