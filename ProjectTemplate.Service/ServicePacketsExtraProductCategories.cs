using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServicePacketsExtraProductCategories : ServiceBase<PacketsExtraProductCategories>,IServicePacketsExtraProductCategories
    {
        public ServicePacketsExtraProductCategories(IBusinessBase<PacketsExtraProductCategories> business) : base(business)
        {
        }
    }
}
