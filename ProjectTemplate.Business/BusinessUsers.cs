using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessUsers:BusinessBase<Users>,IBusinessUsers
    {
        public BusinessUsers(IRepositoryBase<Users> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
