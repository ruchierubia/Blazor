using BlazorEmployeeManagement.Services.Auth.Temp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlazorEmployeeManagement.Controllers.Auth
{
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly ITempAuthService _tempAuthService;

        public AuthController(ITempAuthService tempAuthService)
        {
            _tempAuthService = tempAuthService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(
            [FromForm] string userName,
            [FromForm] string password)
        {
            var user = _tempAuthService.ValidateUser(userName,password);
            if (user == null)
            {
                return Redirect("/login?error=invalid");
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new(ClaimTypes.Name, user.Username),
                new(ClaimTypes.Role, user.Role),
                new("DisplayName", user.DisplayName)
            };
            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            return Redirect("/");
        }
    }
}
