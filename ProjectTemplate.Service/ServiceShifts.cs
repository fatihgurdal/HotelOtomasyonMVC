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
    public class ServiceShifts:ServiceBase<Shifts>,IServiceShifts
    {
        private readonly IBusinessShifts _businessShifts;
        public ServiceShifts(IBusinessBase<Shifts> business, IBusinessShifts businessShifts)
            : base(business)
        {
            _businessShifts = businessShifts;
        }
    }
}
