using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using eCommerceApp.Domain.Entities.Identity;
using eCommerceApp.Domain.Interfaces.Authentication;
using eCommerceApp.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace eCommerceApp.Infrastructure.Repositories.Authentication;

public class RoleManagement(UserManager<AppUser> userManager) : IRoleManagement
{

    public async Task<bool> AddUserToRole(AppUser user, string roleName) =>
        (await userManager.AddToRoleAsync(user, roleName)).Succeeded;
    
    
    public async Task<string?> GetUserRole(string userEmail)
    {
        var user = await userManager.FindByEmailAsync(userEmail);
        return (await userManager.GetRolesAsync(user!)).FirstOrDefault();
    }
    
}
