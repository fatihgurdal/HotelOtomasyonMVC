using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;
using System.Data.Objects;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;


namespace ProjectTemplate.Business
{
    public class BusinessExtraProducts : BusinessBase<ExtraProducts>,IBusinessExtraProducts
   {
        private readonly IRepositoryExtraProducts _repositoryExtraProducts;
        public BusinessExtraProducts(IRepositoryBase<ExtraProducts> repository, IUnitOfWork uow, IRepositoryExtraProducts repositoryExtraProducts)
            : base(repository, uow)
        {
            _repositoryExtraProducts = repositoryExtraProducts;
        }

        public List<ExtraProducts> GetExtraProducts(int PacketId)
        {
           
            return _repositoryExtraProducts.GetExtraProducts(PacketId).ToList();
        }
   }
}
