using System.Collections.Generic;
using System.ComponentModel;
using ProjectTemplate.Core.Abstractions;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class AuthoritiesModel
    {
        public int Id { get; set; }

        [DisplayName("Yetki Adı")]
        public string Name { get; set; }

        [DisplayName("Alt Yetki Id")]
        public int? SubAuthorityId { get; set; }

        [DisplayName("Action Name")]
        public string ActionName { get; set; }

         [DisplayName("Controller Name")]
        public string ControllerName { get; set; }

        [DisplayName("İkon Kodu")]
        public string FaIconCode { get; set; }

        [DisplayName("Alt Yetkiler")]
        public ICollection<Authorities> SubAuthoritys { get; set; }

        [DisplayName("Kullanıcılar")]
        public ICollection<Users> Users { get; set; }

        [DisplayName("Alt Yetki")]
        public Authorities SubAuthority { get; set; }
    }
}
