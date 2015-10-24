using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class StatusesModel
    {
       
        public int Id { get; set; }
        [DisplayName("Durum Adı")]
        public string Name { get; set; }

        public bool IsActive { get; set; }

        //Navigation Property
        [DisplayName("Oda Durumları")]
        public virtual ICollection<RoomStatuses> RoomStatuses { get; set; }
    }
}
