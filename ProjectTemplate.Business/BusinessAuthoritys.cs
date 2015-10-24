using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessAuthoritys:BusinessBase<Authorities>,IBusinessAuthoritys
    {
        public BusinessAuthoritys(IRepositoryBase<Authorities> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
