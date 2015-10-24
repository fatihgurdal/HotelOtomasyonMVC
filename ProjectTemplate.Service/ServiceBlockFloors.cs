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
    public class ServiceBlockFloors:ServiceBase<BlockFloors>,IServiceBlockFloors
    {
        public ServiceBlockFloors(IBusinessBase<BlockFloors> business) : base(business)
        {
        }
    }
}
