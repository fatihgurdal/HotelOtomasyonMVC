using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceNationalities : ServiceBase<Nationalities>,IServiceNationalities
   {
        public ServiceNationalities(IBusinessBase<Nationalities> business) : base(business)
        {
        }
   }
}
