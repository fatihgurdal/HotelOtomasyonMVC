using System.ComponentModel;

namespace WebApplication1.Models
{
   public class HotelFeaturesModel
    {
        public int Id { get; set; }
       [DisplayName("Otel Özellik Adı")]
        public string Name { get; set; }
       public string Content { get; set; }

       public bool IsActive { get; set; }
    }
}
