using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryPaymentMethods : RepositoryBase<PaymentMethods>,IRepositoryPaymentMethods
   {
        public RepositoryPaymentMethods(IRepository repository) : base(repository)
        {
        }
   }
}
