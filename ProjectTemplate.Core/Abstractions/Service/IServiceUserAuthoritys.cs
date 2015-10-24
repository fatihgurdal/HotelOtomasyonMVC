using System.Collections.Generic;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Service
{
    public interface IServiceUserAuthoritys:IServiceBase<UserAuthorities>
    {
        IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId);
    }
}
