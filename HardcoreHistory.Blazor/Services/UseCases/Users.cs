using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Shared.Domain.IdentityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HardcoreHistory.Client.Shared.Interfaces;
using HardcoreHistory.Blazor.Client.ViewModels;
using HardcoreHistory.Client.Interfaces;

namespace HardcoreHistory.Blazor.Services
{
    public class Users 
    {
        private IUserRepository _repo;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        protected IMapper _mapper;

        public Users(IUserRepository repo, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager, IMapper mapper)
        {
            _repo = repo;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }

        public async Task<UsersViewModel> GetUser(ClaimsPrincipal User)
        {
            var user = _userManager.GetUserAsync(User).Result;

            var userModel = new UsersViewModel();
            userModel.FirstName = user.FirstName;
            userModel.LastName = user.LastName;
            userModel.Email = user?.Email;

            return userModel;
        }

        public async Task<List<UsersViewModel>> GetAllUsers()
        {
            var appUsers = _repo.GetUsers();

            var users = _mapper.Map<List<UsersViewModel>>(appUsers);

            return users;
        }


    }
}
