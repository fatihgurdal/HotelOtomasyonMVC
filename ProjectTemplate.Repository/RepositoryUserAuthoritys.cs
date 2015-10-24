using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Repository
{
    public class RepositoryUserAuthoritys : RepositoryBase<UserAuthorities>, IRepositoryUserAuthoritys
    {
        public RepositoryUserAuthoritys(IRepository repository) : base(repository)
        {

        }


        public IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId)
        {
            return Repository.Select<UserAuthorities>().Where(x => x.UserId == userId);

        }
    }
}
