using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class HotelFeatures:IEntityKey<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public bool  IsActive { get; set; }
    }
}
