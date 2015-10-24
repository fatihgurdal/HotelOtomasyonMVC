using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceStatuses:ServiceBase<Statuses>,IServiceStatuses
    {
        private readonly IBusinessStatuses _businessStatuses;
        public ServiceStatuses(IBusinessBase<Statuses> business, IBusinessStatuses businessStatuses)
            : base(business)
        {
            _businessStatuses = businessStatuses;
        }
    }
}
