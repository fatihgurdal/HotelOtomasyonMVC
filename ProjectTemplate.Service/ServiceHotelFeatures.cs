using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceHotelFeatures : ServiceBase<HotelFeatures>,IServiceHotelFeatures
    {
        private readonly IBusinessHotelFeatures _businessHotelFeatures;
        public ServiceHotelFeatures(IBusinessBase<HotelFeatures> business, IBusinessHotelFeatures businessHotelFeatures)
            : base(business)
        {
            _businessHotelFeatures = businessHotelFeatures;
        }
    }
}
