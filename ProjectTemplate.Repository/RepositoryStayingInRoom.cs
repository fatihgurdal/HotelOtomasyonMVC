using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryStayingInRoom : RepositoryBase<StayingInRoom>,IRepositoryStayingInRoom
   {
        public RepositoryStayingInRoom(IRepository repository) : base(repository)
        {
        }
   }
}
