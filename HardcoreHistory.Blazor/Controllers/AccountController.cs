using System.Threading.Tasks;
using AutoMapper;
using HardcoreHistory.Blazor.Services;
using HardcoreHistory.Client.Shared.Domain;
using HardcoreHistory.Client.Shared.Domain.IdentityModels;
using HardcoreHistory.Client.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using HardcoreHistory.Blazor.Client.ViewModels;

namespace HardcoreHistory.Blazor.Controllers
{
    [Route("account")]
    [ApiController]
    public class AccountController : Base.BaseController
    {
        private Users _users;

        public AccountController(IUserRepository repo, IMapper mapper, SignInManager<ApplicationUser> signInManager,
            UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager) : base(repo, mapper, signInManager, userManager, roleManager)
        {
            _users = new Users(repo, userManager, roleManager, mapper);
        }

        public IActionResult Index(UsersViewModel vm)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            string mail = user?.Email;
            string firstname = user?.FirstName;
            string lastname = user?.LastName;
            return View(new UsersViewModel
            {
                FirstName = firstname,
                LastName = lastname,
                Email = mail
            });
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (!ModelState.IsValid) return View(vm);
            {

                var user = new ApplicationUser { UserName = vm.Email, Email = vm.Email, FirstName = vm.FirstName, LastName = vm.LastName };
                var result = await _userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Customer").Wait();
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
            }

            return View(vm);
        }

    }
}
