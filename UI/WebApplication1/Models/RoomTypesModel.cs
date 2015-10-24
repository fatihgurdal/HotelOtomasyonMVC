using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class RoomTypesModel
    {
        public int Id { get; set; }
        [DisplayName("Oda Tip Adı")]
        public string Name { get; set; }
        [DisplayName("Fiyat")]
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Kapasite")]
        public byte Quota { get; set; }

        [DisplayName("Odalar")]
        public virtual ICollection<Rooms> Rooms { get; set; }
        [DisplayName("Oda Özellik Oda Tipleri")]
        public virtual ICollection<RoomFeaturesRoomTypes> RoomFeaturesRoomTypes { get; set; }
    }
}
