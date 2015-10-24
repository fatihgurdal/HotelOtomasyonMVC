

using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class RoomFeaturesRoomTypesModel
    {
        public int Id { get; set; }
       [DisplayName("Özellik Miktarı")]
        public byte RoomFeatureQuantity { get; set; }
       [DisplayName("Oda Tip Id")]
        public int RoomTypeId { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Oda Özellik  Id")]
        public int RoomFeatureId { get; set; }
       [DisplayName("Oda Özellik")]
        public virtual RoomFeatures RoomFeature { get; set; }
       [DisplayName("Oda Tip")]
        public virtual RoomTypes RoomType { get; set; }
       
    }
}
