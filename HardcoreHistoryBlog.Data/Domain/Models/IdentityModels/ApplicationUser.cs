using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistoryBlog.Domain.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
        public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
        public virtual IEnumerable<ApplicationRole> Roles { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public ICollection<MainComment> MainComments { get; set; }
    }
}
