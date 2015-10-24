using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class RoomFeaturesRoomTypes:IEntityKey<int>
    {
        public int Id { get; set; }
        public byte RoomFeatureQuantity { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomFeatureId { get; set; }
        public bool IsActive { get; set; }
        public virtual RoomFeatures RoomFeature { get; set; }
        public virtual RoomTypes RoomType { get; set; }
       
    }
}
