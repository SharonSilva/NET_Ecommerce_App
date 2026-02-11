using eCommerceApp.Domain.Entities.Identity;
using eCommerceApp.Domain.Interfaces.Authentication;
using Microsoft.AspNetCore.Identity;

namespace eCommerceApp.Infrastructure.Repositories.Authentication;

public class RoleManagement(UserManager<AppUser> userManager) : IRoleManagement
{
    public Task<string?> GetUserRole(string userEmail)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddUserToRole(AppUser user, string roleName)
    {
        throw new NotImplementedException();
    }
}