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
    public class ServiceExtraProducts:ServiceBase<ExtraProducts>,IServiceExtraProducts
    {
        private readonly IBusinessExtraProducts _businessExtraProducts;
        public ServiceExtraProducts(IBusinessBase<ExtraProducts> business, IBusinessExtraProducts businessExtraProducts)
            : base(business)
        {
            _businessExtraProducts = businessExtraProducts;
        }

        public List<ExtraProducts> GetExtraProducts(int PacketId)
        {
            return _businessExtraProducts.GetExtraProducts(PacketId).ToList();
        }
    }
}
