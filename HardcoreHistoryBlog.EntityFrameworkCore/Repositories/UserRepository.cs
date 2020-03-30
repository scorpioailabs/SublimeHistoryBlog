using AutoMapper;
using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using HardcoreHistoryBlog.Domain.Interfaces;
using HardcoreHistoryBlog.Infrastructure.Context;
using HardcoreHistoryBlog.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardcoreHistoryBlog.Infrastructure.Repositories
{
    public class UserRepository : EntityBaseRepository<ApplicationUser>, IUserRepository
    {
        private ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context, IMapper mapper)
            : base(context, mapper)
        {
            _context = context;
        }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public void AddRole(ApplicationRole role)
        {
            _context.Roles.Add(role);
        }

        public void AddUser(ApplicationUser user)
        {
            _context.Add(user);
        }

        public List<ApplicationRole> AllRoles()
        {
            return _context.Roles.ToList();
        }

        public ApplicationRole GetRole(string id)
        {
            return _context.Roles.Find(id);
        }

        public ApplicationUser GetUser(string Id)
        {
            return _context.Users.Find(Id);
        }

        public List<ApplicationUser> GetUsers()
        {
            var bloggers = _userManager.GetUsersInRoleAsync("Client").Result;
            var admins = _userManager.GetUsersInRoleAsync("Admin").Result;

            var list = new List<ApplicationUser>();
            foreach (ApplicationUser b in bloggers)
                list.Add(b);
            foreach (ApplicationUser a in admins)
                list.Add(a);

            return list;
        }

        public async Task<bool> SaveChangesAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void UpdateRole(ApplicationRole role)
        {
            _context.Entry(role).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
