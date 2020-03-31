using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Shared.Domain.IdentityModels;
using HardcoreHistory.Client.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Interfaces
{
    public interface IUserRepository : IBaseRepository<ApplicationUser>
    {
        List<ApplicationUser> GetUsers();
        void AddUser(ApplicationUser user);
        List<ApplicationRole> AllRoles();
        ApplicationRole GetRole(string id);
        void AddRole(ApplicationRole role);
        void UpdateRole(ApplicationRole role);
        ApplicationUser GetUser(string Id);
    }
}
