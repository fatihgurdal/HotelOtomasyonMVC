using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class PermitTypesModel
   {
        public int Id { get; set; }
       [DisplayName("İzin Tip Adı")]
        public string Name { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Açıklama")]
        public string Description { get; set; }
       [DisplayName("Ücretli Mi")]
        public bool IsPaid { get; set; }
       [DisplayName("İzinler")]
        public virtual ICollection<Permits> Permits { get; set; }
    }
}
