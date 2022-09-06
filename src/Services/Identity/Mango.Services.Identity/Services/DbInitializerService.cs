using IdentityModel;
using Mango.Services.Identity.Context;
using Mango.Services.Identity.Models;
using Mango.Services.Identity.Services.Contracts;
using Microsoft.AspNetCore.Identity;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Mango.Services.Identity.Services
{
    internal sealed class DbInitializerService : IDbInitializerService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializerService(ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Dispose()
        {
            _context.Dispose();
            _userManager.Dispose();
            _roleManager.Dispose();
        }

        public async Task Initialize()
        {
            var adminRole = await _roleManager.FindByNameAsync(IdentityConfig.Admin);
            var customerRole = await _roleManager.FindByNameAsync(IdentityConfig.Customer);

            if (adminRole != null && customerRole != null)
            {
                return;
            }

            await _roleManager.CreateAsync(new IdentityRole(IdentityConfig.Admin));
            await _roleManager.CreateAsync(new IdentityRole(IdentityConfig.Customer));

            var adminUser = new ApplicationUser()
            {
                UserName = "admin1",
                Email = "admin1@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "07707721654",
                FirstName = "Ben",
                LastName = "Admin"
            };

            await _userManager.CreateAsync(adminUser, "Admin123*");
            await _userManager.AddToRoleAsync(adminUser, IdentityConfig.Admin);
            await _userManager.AddClaimsAsync(adminUser, new Claim[]
            {
                new Claim(JwtClaimTypes.Name, adminUser.FirstName + " " + adminUser.LastName),
                new Claim(JwtClaimTypes.GivenName, adminUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName, adminUser.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfig.Admin)
            });

            var customerUser = new ApplicationUser()
            {
                UserName = "customer1",
                Email = "customer1@gmail.com",
                EmailConfirmed = true,
                PhoneNumber = "077021465165",
                FirstName = "Ben",
                LastName = "Customer"
            };

            await _userManager.CreateAsync(customerUser, "Customer123*");
            await _userManager.AddToRoleAsync(customerUser, IdentityConfig.Customer);
            await _userManager.AddClaimsAsync(customerUser, new Claim[]
            {
                new Claim(JwtClaimTypes.Name, customerUser.FirstName + " " + customerUser.LastName),
                new Claim(JwtClaimTypes.GivenName, customerUser.FirstName),
                new Claim(JwtClaimTypes.FamilyName, customerUser.LastName),
                new Claim(JwtClaimTypes.Role, IdentityConfig.Customer)
            });
        }
    }
}
