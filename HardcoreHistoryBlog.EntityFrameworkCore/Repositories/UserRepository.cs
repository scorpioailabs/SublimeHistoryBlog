using AutoMapper;
using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using HardcoreHistoryBlog.Domain.Interfaces;
using HardcoreHistoryBlog.Infrastructure.Context;
using HardcoreHistoryBlog.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HardcoreHistoryBlog.Infrastructure.Repositories
{
    public class UserRepository : EntityBaseRepository<ApplicationUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public void AddRole(ApplicationRole role)
        {
            throw new NotImplementedException();
        }

        public void AddUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public List<ApplicationRole> AllRoles()
        {
            throw new NotImplementedException();
        }

        public ApplicationRole GetRole(string id)
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUser(string Id)
        {
            throw new NotImplementedException();
        }

        public void GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateRole(ApplicationRole role)
        {
            throw new NotImplementedException();
        }
    }
}
