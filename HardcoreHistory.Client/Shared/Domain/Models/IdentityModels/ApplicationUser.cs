using HardcoreHistory.Client.Shared.Domain.IdentityModels;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using IdentityUser = Microsoft.AspNetCore.Identity.IdentityUser;

namespace HardcoreHistory.Client.Shared.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Microsoft.AspNetCore.Identity.IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<Microsoft.AspNetCore.Identity.IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual IEnumerable<ApplicationRole> Roles { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public ICollection<MainComment> MainComments { get; set; }
    }
}
