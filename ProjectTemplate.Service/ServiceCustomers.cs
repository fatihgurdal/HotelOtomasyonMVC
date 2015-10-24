using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceCustomers : ServiceBase<Customers>, IServiceCustomers
   {
        private readonly IBusinessCustomers _businessCustomers;
        public ServiceCustomers(IBusinessBase<Customers> business, IBusinessCustomers businessCustomers)
            : base(business)
        {
            _businessCustomers = businessCustomers;
        }
   }
}
