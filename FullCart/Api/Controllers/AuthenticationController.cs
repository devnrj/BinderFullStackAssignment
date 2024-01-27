using Microsoft.AspNetCore.Mvc;
using FullCart.Contracts.Authentication;
namespace FullCart.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("register")]    
    public IActionResult Register([FromBody]RegisterRequest request)
    {
        return Ok(request);
    }

    [HttpPost("login")]    
    public IActionResult Login(LoginRequest request)
    {
        return Ok(request);
    }

    [HttpPost("logout")]    
    public IActionResult Logout(LogoutRequest request)
    {
        return Ok(request);
    }
}