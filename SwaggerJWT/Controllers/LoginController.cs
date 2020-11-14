using Microsoft.AspNetCore.Mvc;
using SwaggerJWT.Database;
using SwaggerJWT.Models;
using SwaggerJWT.Services;

namespace SwaggerJWT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public object Login(User user)
        {
            User authUser = UserDatabase.Get(user.Login, user.Password);

            if (authUser == null)
                return NotFound(new { message = "Invalid credentials" });

            string token = TokenService.GenerateToken(user, Startup.PrivateKey);

            user.Password = "";

            return new
            {
                user = user,
                token = token
            };
        }
    }
}
