using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class NationalitiesModel
    {
       
        public int Id { get; set; }
        [StringLength(4, MinimumLength = 2)]
        [DisplayName("Uyruk Adı"), Required]
        public string  Name { get; set; }
        [DisplayName("Ülke Adı"),Required]
        [StringLength(30, MinimumLength = 3)]
        public string CountryName { get; set; }
        [DisplayName("Müşteriler")]
        public ICollection<Customers> Customers { get; set; }
    }
}
