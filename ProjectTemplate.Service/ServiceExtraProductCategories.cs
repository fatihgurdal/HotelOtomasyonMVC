using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceExtraProductCategories : ServiceBase<ExtraProductCategories>, IServiceExtraProductCategories
   {
        private readonly IBusinessExtraProductCategories _businessExtraProductCategories;
        public ServiceExtraProductCategories(IBusinessBase<ExtraProductCategories> business, IBusinessExtraProductCategories businessExtraProductCategories)
            : base(business)
       {
           _businessExtraProductCategories = businessExtraProductCategories;
       }
   }
}
