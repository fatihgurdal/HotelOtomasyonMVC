using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class DepartmentsModel
    {
      
        public int Id { get; set; }
       [DisplayName("Departman Adı")]
        public string Name { get; set; }
       public bool IsActive { get; set; }
       [DisplayName("Personel Grupları")]

       
        public  ICollection<GroupsOfEmployee> GroupsOfEmployee { get; set; }
    }
}
