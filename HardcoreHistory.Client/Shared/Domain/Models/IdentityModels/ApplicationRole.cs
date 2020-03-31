using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HardcoreHistory.Client.Shared.Domain.IdentityModels
{
    public class ApplicationRole : Microsoft.AspNetCore.Identity.IdentityRole

    {
        public ApplicationRole() : base() { }

        public ApplicationRole(string name)
            : base(name)
        { }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
        public string Description { get; set; }
    }
}
