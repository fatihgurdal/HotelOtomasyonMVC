using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Repository
{
    public interface IRepositoryUserAuthoritys:IRepositoryBase<UserAuthorities>
    {
        IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId);
    }
}
