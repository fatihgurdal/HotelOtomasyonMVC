using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
  public  class GroupsOfEmployeeModel
  {
      
        public int Id { get; set; }
      [DisplayName("Personel Grup Adı")]
        public string Name { get; set; }
      public bool IsActive { get; set; }
      [DisplayName("Departman Id")]
        public int DepartmentId { get; set; }
      [DisplayName("Departman")]
        public  Departments Department { get; set; }
      [DisplayName("Personeller")]
        public ICollection<Employees> Employees { get; set; }
    }
}
