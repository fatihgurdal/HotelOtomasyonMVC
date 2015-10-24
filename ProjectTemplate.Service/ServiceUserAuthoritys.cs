using System.Collections.Generic;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceUserAuthoritys : ServiceBase<UserAuthorities>, IServiceUserAuthoritys
    {
        private readonly IBusinessUserAuthoritys _businessuserauthoritys;
        public ServiceUserAuthoritys(IBusinessBase<UserAuthorities> business,IBusinessUserAuthoritys userAuthoritys) : base(business)
        {
            _businessuserauthoritys = userAuthoritys;
        }

        public IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId)
        {
            //Modele çevilecek
            return _businessuserauthoritys.GetUserAuthoritieses(userId);
        }
    }
}
