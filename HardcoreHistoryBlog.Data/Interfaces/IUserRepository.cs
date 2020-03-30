using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using HardcoreHistoryBlog.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<ApplicationUser>
    {
        void GetUsers();
        void AddUser(ApplicationUser user);
        List<ApplicationRole> AllRoles();
        ApplicationRole GetRole(string id);
        void AddRole(ApplicationRole role);
        void UpdateRole(ApplicationRole role);
        ApplicationUser GetUser(string Id);
    }
}
