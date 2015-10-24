using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace ProjectTemplate.Repository
{
    public class RepositoryExtraProducts : RepositoryBase<ExtraProducts>,IRepositoryExtraProducts
    {
        public RepositoryExtraProducts(IRepository repository) : base(repository)
        {
        }

        public List<ExtraProducts> GetExtraProducts(int PacketId)
        {
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("PacketId",PacketId);

            return Repository.Query<ExtraProducts>("SP_ExtraProducts @PacketId", param).ToList();
        }
    }
}
