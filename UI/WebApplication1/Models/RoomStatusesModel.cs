using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class RoomStatusesModel
    {
        public int Id { get; set; }
        [DisplayName("Durum Id")]
        public int StatusId { get; set; }
        public int RoomId { get; set; }
        public bool IsActive { get; set; }

        //Navigation property
        [DisplayName("Odalar")]
        public  Rooms Room { get; set; }
        [DisplayName("Durum")]
        public  Statuses Status { get; set; }
    }
}
