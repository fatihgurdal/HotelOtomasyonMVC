using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryUsers : RepositoryBase<Users>,IRepositoryUsers
   {
        public RepositoryUsers(IRepository repository) : base(repository)
        {
        }
   }
}
