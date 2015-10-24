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
    public class ServiceSaleExtras:ServiceBase<SaleExtras>,IServiceSaleExtras
    {
        private readonly IBusinessSaleExtras _businessSaleExtras;
        public ServiceSaleExtras(IBusinessBase<SaleExtras> business, IBusinessSaleExtras businessSaleExtras)
            : base(business)
        {
            _businessSaleExtras = businessSaleExtras;
        }
    }
}
