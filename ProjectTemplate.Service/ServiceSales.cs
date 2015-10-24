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
    public class ServiceSales:ServiceBase<Sales>,IServiceSales
    {
        private readonly IBusinessSales _businessSales;
        public ServiceSales(IBusinessBase<Sales> business, IBusinessSales businessSales)
            : base(business)
        {
        _businessSales= businessSales;
        }
    }
}
