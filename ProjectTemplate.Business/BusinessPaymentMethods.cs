using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessPaymentMethods : BusinessBase<PaymentMethods>,IBusinessPaymentMethods
   {
        private readonly IRepositoryPaymentMethods _repositoryPaymentMethods;
        public BusinessPaymentMethods(IRepositoryBase<PaymentMethods> repository, IUnitOfWork uow, IRepositoryPaymentMethods repositoryPaymentMethods)
            : base(repository, uow)
        {
            _repositoryPaymentMethods = repositoryPaymentMethods;
        }
   }
}
