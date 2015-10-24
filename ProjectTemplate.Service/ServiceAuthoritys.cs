using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceAuthoritys : ServiceBase<Authorities>, IServiceAuthoritys
    {
        public ServiceAuthoritys(IBusinessBase<Authorities> business) : base(business)
        {
        }
    }
}
