using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using UserManager.Models;

namespace UserManager.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> //Use ApplicationUser instead of IdentityUser
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Create roles
            string superAdminID = Guid.NewGuid().ToString();
            string adminID = Guid.NewGuid().ToString();
            string moderatorID = Guid.NewGuid().ToString();
            string userID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = superAdminID, Name = "SuperAdmin", NormalizedName = "SUPERADMIN".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = adminID, Name = "Admin", NormalizedName = "ADMIN".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = moderatorID, Name = "Moderator", NormalizedName = "MODERATOR".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = userID, Name = "User", NormalizedName = "USER".ToUpper() });


            //Create default user
            ApplicationUser user = new()
            {
                UserName = "superadmin",
                NormalizedUserName = "SUPERADMIN",
                Email = "jennyrigsjo@gmail.com",
                NormalizedEmail = "jennyrigsjo@gmail.com",
                FirstName = "Jenny",
                LastName = "Rigsjö",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                LockoutEnabled = false,
            };

            PasswordHasher<ApplicationUser> passwordHasher = new();
            user.PasswordHash = passwordHasher.HashPassword(user, "Superadmin*123");

            builder.Entity<ApplicationUser>().HasData(user);


            //Assign role to default user
            builder.Entity<IdentityUserRole<string>>().HasData( new IdentityUserRole<string> {RoleId = superAdminID, UserId = user.Id} );

        }


    }
}