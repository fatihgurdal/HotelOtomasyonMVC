using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServicePermitTypes : ServiceBase<PermitTypes>, IServicePermitTypes
    {
        public ServicePermitTypes(IBusinessBase<PermitTypes> business) : base(business)
        {
        }
    }
}
