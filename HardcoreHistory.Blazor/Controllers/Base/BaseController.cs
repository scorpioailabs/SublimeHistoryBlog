using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Shared.Domain.IdentityModels;
using HardcoreHistory.Client.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HardcoreHistory.Blazor.Controllers.Base
{
    public class BaseController : Controller
    {
        protected IUserRepository _repo;
        protected IMapper _mapper;
        protected SignInManager<ApplicationUser> _signInManager;
        protected UserManager<ApplicationUser> _userManager;
        protected RoleManager<ApplicationRole> _roleManager;

        public BaseController(IUserRepository repo, IMapper mapper, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _repo = repo;
            _mapper = mapper;
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }
    }
}
