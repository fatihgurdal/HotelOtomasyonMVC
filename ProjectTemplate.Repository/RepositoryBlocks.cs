using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
   public class RepositoryBlocks:RepositoryBase<Blocks>,IRepositoryBlocks
   {
       public RepositoryBlocks(IRepository repository) : base(repository)
       {
       }


   }
}
