using ProjectTemplate.Core.Abstractions.Business;
using ProjectTemplate.Core.Abstractions.Service;
using ProjectTemplate.Core.Entities;

namespace ProjectTemplate.Service
{
    public class ServiceGroupsOfEmployee:ServiceBase<GroupsOfEmployee>,IServiceGroupsOfEmployee
    {
        private readonly IBusinessGroupsOfEmployee _businessGroupsOfEmployee;
        public ServiceGroupsOfEmployee(IBusinessBase<GroupsOfEmployee> business, IBusinessGroupsOfEmployee businessGroupsOfEmployee)
            : base(business)
        {
            _businessGroupsOfEmployee = businessGroupsOfEmployee;
        }
    }
}
