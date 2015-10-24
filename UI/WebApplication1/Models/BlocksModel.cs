
using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
  public  class BlocksModel
  {
     
        public int Id { get; set; }

      [DisplayName("Blok Adı")]
        public string BlockName { get; set; }
      public bool IsActive { get; set; }
      [DisplayName("Blok Katları")]
      public  ICollection<BlockFloors> BlockFloors { get; set; }

    }
}
