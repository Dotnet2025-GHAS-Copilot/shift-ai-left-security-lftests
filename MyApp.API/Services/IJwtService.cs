using System;
using System.Security.Claims;

namespace MyApp.API.Services
{
    public interface IJwtService
    {
        string GenerateToken(string userId, string userName = null);
        ClaimsPrincipal ValidateToken(string token);
    }
}