using ProjectTemplate.Core.Abstractions;

namespace ProjectTemplate.Core.Entities
{
    public class UserAuthorities:IEntityKey<int>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuthorityId { get; set; }
        public virtual Authorities Authority { get; set; }
        public virtual Users User { get; set; }
    }
}
