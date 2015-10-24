using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessNationalities : BusinessBase<Nationalities>,IBusinessNationalities
    {
        public BusinessNationalities(IRepositoryBase<Nationalities> repository, IUnitOfWork uow) : base(repository, uow)
        {
        }
    }
}
