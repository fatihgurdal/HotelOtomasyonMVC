
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
   public class UsersModel
   {
      
        public int Id { get; set; }
       [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
       [DisplayName("Kullanıcı Şifresi"),DataType(DataType.Password)]
        public string Password { get; set; }
       [DisplayName("Çalışan Id")]
        public int EmployeeId { get; set; }
       [DisplayName("Çalışan")]
       public virtual Employees Employee { get; set; }
    }
}
