using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryHotelFeatures : RepositoryBase<HotelFeatures>,IRepositoryHotelFeatures
   {
        public RepositoryHotelFeatures(IRepository repository) : base(repository)
        {
        }
   }
}
