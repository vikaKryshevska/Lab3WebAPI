using Lab3WebAPI.Entities;
using Microsoft.AspNetCore.Identity;

namespace Lab3WebAPI.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(IdentityUser user, String role);
    }
}
