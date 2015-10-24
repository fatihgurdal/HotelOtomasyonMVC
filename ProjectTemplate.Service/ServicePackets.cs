using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServicePackets : ServiceBase<Packets>,IServicePackets
   {
        private readonly IBusinessPackets _businessPackets;
        public ServicePackets(IBusinessBase<Packets> business, IBusinessPackets businessPackets) : base(business)
        {
            _businessPackets = businessPackets;
        }
   }
}
