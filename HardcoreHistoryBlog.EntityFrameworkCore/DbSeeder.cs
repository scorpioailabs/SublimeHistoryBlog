using HardcoreHistoryBlog.Domain.Domain.Models;
using HardcoreHistoryBlog.Domain.Domain.Models.IdentityModels;
using HardcoreHistoryBlog.Infrastructure.Context;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardcoreHistoryBlog.Infrastructure
{
    public class DbSeeder
    {
        public static void SeedDb
            (ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();
            {


                if (!roleManager.RoleExistsAsync
                    ("Admin").Result)
                {
                    ApplicationRole role = new ApplicationRole
                    {
                        Name = "Admin"
                    };
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                if (!roleManager.RoleExistsAsync
                    ("Customer").Result)
                {
                    ApplicationRole role = new ApplicationRole
                    {
                        Name = "Customer"
                    };
                    IdentityResult roleResult = roleManager.
                    CreateAsync(role).Result;
                }

                // Creating an admin user

                //Client user = new Client
                //{
                //    UserName = "Member1@email.com",
                //    Email = "Member1@email.com",
                //    FirstName = "Member1",
                //    LastName = "Member1"
                //};

                //IdentityResult result = userManager.CreateAsync
                //(user, "Password123!").Result;

                //if (result.Succeeded)
                //{
                //    userManager.AddToRoleAsync(user,
                //    "Admin").Wait();
                //}
            }

            if (!context.Posts.Any())
            {
                context.Posts.Add(new Post() { Title = "My first post", Short_Description = "Test post in Hardcore History", Content = "The Mongols- A short, bloody account." });
                context.SaveChanges();
            }
        }
    }
}
