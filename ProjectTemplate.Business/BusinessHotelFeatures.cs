using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessHotelFeatures : BusinessBase<HotelFeatures>,IBusinessHotelFeatures
    {
        private readonly IRepositoryHotelFeatures _repositoryHotelFeatures;
        public BusinessHotelFeatures(IRepositoryBase<HotelFeatures> repository, IUnitOfWork uow, IRepositoryHotelFeatures repositoryHotelFeatures)
            : base(repository, uow)
        {
            _repositoryHotelFeatures = repositoryHotelFeatures;
        }
    }
}
