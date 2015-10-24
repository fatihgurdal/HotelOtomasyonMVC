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
    public class ServicePaymentMethods:ServiceBase<PaymentMethods>,IServicePaymentMethods
    {
        private readonly IBusinessPaymentMethods _businessPaymentMethods;
        public ServicePaymentMethods(IBusinessBase<PaymentMethods> business, IBusinessPaymentMethods businessPaymentMethods)
            : base(business)
        {
            _businessPaymentMethods = businessPaymentMethods;
        }
    }
}
