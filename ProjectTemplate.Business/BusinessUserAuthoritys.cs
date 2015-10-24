using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Repository;
using ProjectTemplate.Core.Entities;
using ProjectTemplate.Core.Repository;

namespace ProjectTemplate.Business
{
    public class BusinessUserAuthoritys:BusinessBase<UserAuthorities>,IBusinessUserAuthoritys
    {
        private readonly IRepositoryUserAuthoritys _repositoryUserAuthoritys;
        public BusinessUserAuthoritys(IRepositoryBase<UserAuthorities> repository, IUnitOfWork uow, IRepositoryUserAuthoritys repositoryUserAuthoritys)
            : base(repository, uow)
        {
            _repositoryUserAuthoritys = repositoryUserAuthoritys;
        }

        public IEnumerable<UserAuthorities> GetUserAuthoritieses(int userId)
        {
            return _repositoryUserAuthoritys.GetUserAuthoritieses(userId).OrderBy(x => x.AuthorityId).ToList();
        }
    }
}
