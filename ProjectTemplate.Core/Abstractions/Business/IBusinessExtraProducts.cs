using ProjectTemplate.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessExtraProducts:IBusinessBase<ExtraProducts>
    {
        List<ExtraProducts> GetExtraProducts(int PacketId);
    }
}
