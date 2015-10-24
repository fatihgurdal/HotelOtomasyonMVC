using System.ComponentModel;
using ProjectTemplate.Core.Entities;

namespace WebApplication1.Models
{
    public class UserAuthoritiesModel
    {
        public int Id { get; set; }
        [DisplayName("Kullanici Id")]
        public int UserId { get; set; }
        [DisplayName("Yetki Id")]
        public int AuthorityId { get; set; }
        [DisplayName("Yetki")]
        public Authorities Authority { get; set; }
        [DisplayName("Kullanici")]
        public Users User { get; set; }
    }
}
