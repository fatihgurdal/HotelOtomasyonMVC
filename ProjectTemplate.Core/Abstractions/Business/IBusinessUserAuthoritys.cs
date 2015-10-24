using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Core.Abstractions.Business
{
    public interface IBusinessUserAuthoritys:IBusinessBase<UserAuthorities>
    {
        IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId);
    }
}
