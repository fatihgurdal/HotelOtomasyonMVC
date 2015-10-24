using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceDiscounts : ServiceBase<Discounts>,IServiceDiscounts
    {
        private readonly IBusinessDiscounts _businessDiscounts;
        public ServiceDiscounts(IBusinessBase<Discounts> business, IBusinessDiscounts businessDiscounts)
            : base(business)
        {
            _businessDiscounts = businessDiscounts;
        }
    }
}
