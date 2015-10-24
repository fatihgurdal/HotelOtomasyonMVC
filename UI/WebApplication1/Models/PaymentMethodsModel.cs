using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class PaymentMethodsModel
    {
        
        public int Id { get; set; }
         [DisplayName("Ödeme Yöntemi")]
        public string Name { get; set; }
         public bool IsActive { get; set; }

         [DisplayName("Satışlar")]
        public ICollection<Sales> Sales { get; set; }
    }
}
