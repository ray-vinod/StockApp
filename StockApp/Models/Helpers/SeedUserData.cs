using Microsoft.AspNetCore.Identity;
using StockApp.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockApp.Models.Helpers
{
    public class SeedUserData
    {
        public static async Task InitializeAsync(AppDbContext db,
                                UserManager<AppUser> userManager,
                                RoleManager<IdentityRole> roleManager)
        {
            db.Database.EnsureCreated();

            //List of static roles
            var roles = new List<string>
            {
                "Root",
                "Admin",
                "Editor",
                "Member",
                "Visitor"
            };

            //setting root password for the root user
            string rootPassword = "P@$$0rdVinod";
            string rootRole = "Root";
            //Creating all the roles if not available
            foreach (var role in roles)
            {
                if (await roleManager.FindByNameAsync(role) == null)
                {
                    var result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //creating root user
            if (await userManager.FindByNameAsync("root@ciwec.np") == null)
            {
                var rootUser = new AppUser
                {
                    FName = "root",
                    MName = "",
                    LName = "root",
                    Email = "root@ciwec.com",
                    UserName = "root@ciwec.com",
                    EmailConfirmed = true,

                    CreationDate = DateTime.Now.Date
                };
                var result = await userManager.CreateAsync(rootUser);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(rootUser, rootPassword);
                    await userManager.AddToRoleAsync(rootUser, rootRole);
                }
            }


        }
    }
}
