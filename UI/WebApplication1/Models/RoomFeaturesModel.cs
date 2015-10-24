using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class RoomFeaturesModel
    {
      
        public int Id { get; set; }
       [DisplayName("Özellik Adı")]
        public string Name { get; set; }

       public bool IsActive { get; set; }
       [DisplayName("Oda Tipinin Özellikleri")]
        public virtual ICollection<RoomFeaturesRoomTypes> RoomFeaturesRoomTypes { get; set; }
    }
}
