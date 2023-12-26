using Microsoft.AspNetCore.Identity;

namespace AuthenticationDemo.API
{
    public static class SeedDatabase
    {
        public static async Task AddAdminUser(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

                string[] roleNames = { "Admin", "User" };
                foreach (var roleName in roleNames)
                {
                    var roleExist = await roleManager.RoleExistsAsync(roleName);
                    if (!roleExist)
                    {
                        // Create the roles and seed them to the database
                        await roleManager.CreateAsync(new IdentityRole(roleName));
                    }
                }

                // Check if the admin user already exists
                var adminUser = await userManager.FindByNameAsync("admin");
                if (adminUser == null)
                {
                    // Create a new admin user
                    adminUser = new IdentityUser
                    {
                        UserName = "admin",
                        Email = "admin@example.com",
                        EmailConfirmed = true
                        // Add additional properties as needed
                    };

                    // Set a strong password for the admin user
                    var password = "Admin@123";
                    await userManager.CreateAsync(adminUser, password);

                    // Assign the admin role to the admin user
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                }
            }
        }
    }

}
