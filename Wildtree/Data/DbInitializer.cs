using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wildtree.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Wildtree.Data
{
    public static class DbInitializer
      {
        public static async void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context), null, null, null, null, null);
                var store = new RoleStore<IdentityRole>(context);
                var userStore = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(userStore, null, null, null, null, null, null, null, null);

                if(!context.Roles.Any(r => r.Name == "Butcher"))
                {
                    var role = new IdentityRole { Name = "Butcher" };
                    await roleManager.CreateAsync(role);
                }
                if(!context.Roles.Any(r => r.Name == "Rep"))
                {
                    var role = new IdentityRole { Name = "Rep" };
                    await roleManager.CreateAsync(role);
                }

            }
        }
      }
  }
