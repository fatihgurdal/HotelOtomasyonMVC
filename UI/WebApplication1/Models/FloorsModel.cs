

using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class FloorsModel
   {
       
        public int Id { get; set; }
        [DisplayName("Kat Adı")]
        public string Name { get; set; }

        public bool IsActive { get; set; }
       [DisplayName("Blok Katları")]
        public ICollection<BlockFloors> BlockFloors { get; set; }
    }
}
