using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
   public class Users:IEntityKey<int>
   {
       public Users()
       {
           UserAuthorities = new HashSet<UserAuthorities>();
       }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employees Employee { get; set; }

        public ICollection<UserAuthorities> UserAuthorities { get; set; }
    }
}
