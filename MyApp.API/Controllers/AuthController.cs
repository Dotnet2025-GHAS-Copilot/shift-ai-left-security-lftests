using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApp.API.Services;
using System.ComponentModel.DataAnnotations;

namespace MyApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IJwtService _jwtService;

        public AuthController(IJwtService jwtService)
        {
            _jwtService = jwtService;
        }

        /// <summary>
        /// Generate JWT token for testing purposes
        /// </summary>
        /// <param name="request">Login credentials</param>
        /// <returns>JWT token</returns>
        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            // For demo purposes - simple validation
            // In production, validate against database/identity provider
            if (request?.Username == "testuser" && request?.Password == "testpass123")
            {
                var token = _jwtService.GenerateToken(request.Username, request.Username);
                return Ok(new { token = token, expiresIn = 3600 });
            }

            return Unauthorized(new { message = "Invalid credentials" });
        }
    }

    public class LoginRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}