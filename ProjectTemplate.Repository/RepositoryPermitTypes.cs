using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryPermitTypes : RepositoryBase<PermitTypes>,IRepositoryPermitTypes
   {
        public RepositoryPermitTypes(IRepository repository) : base(repository)
        {
        }
   }
}
