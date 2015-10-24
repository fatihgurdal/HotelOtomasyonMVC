using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryAuthoritys:RepositoryBase<Authorities>,IRepositoryAuthoritys
    {
        public RepositoryAuthoritys(IRepository repository) : base(repository)
        {
        }
    }
}
