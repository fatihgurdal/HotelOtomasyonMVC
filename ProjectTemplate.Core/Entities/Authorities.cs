using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class Authorities:IEntityKey<int>
    {
        public Authorities()
        {
            SubAuthoritys=new HashSet<Authorities>();
            UserAuthorities = new HashSet<UserAuthorities>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SubAuthorityId { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string FaIconCode { get; set; }

        public virtual ICollection<Authorities> SubAuthoritys { get; set; }
        public virtual Authorities SubAuthority { get; set; }

        public virtual ICollection<UserAuthorities> UserAuthorities { get; set; }
    }
}
