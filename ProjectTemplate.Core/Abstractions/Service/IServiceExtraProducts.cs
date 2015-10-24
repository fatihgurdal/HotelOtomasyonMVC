using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceExtraProducts:IServiceBase<ExtraProducts>
    {
        List<ExtraProducts> GetExtraProducts(int PacketId);
    }
}
