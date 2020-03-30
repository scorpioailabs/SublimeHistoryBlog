using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardcoreHistory.Blazor.ViewModels
{
    public class UserRolesViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Rolename { get; set; }
        public string RoleId { get; set; }
        [Display(Name = "Select Role")]
        public ApplicationRole Role { get; set; }
    }
}
