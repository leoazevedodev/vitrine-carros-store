using VitrineCarrosApi.Settings;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace VitrineCarrosApi.Authentication
{
    [ApiController]
    public class LoginController : Controller
    {
        [HttpPost]
        [Route("api/auth/login")]
        public async Task<IActionResult> Auth([FromBody] LoginBody login)
        {
            try
            {

                SqlConnection connection = new SqlConnection(Connections.identidadeacesso);
                LoginService user = new LoginService();

                var usuario = await user.GetUserLogin(login.email, login.senha);

                if (usuario.Count == 0)
                    throw new Exception("Usuário ou Senha Inválido !");


                var token = TokenService.GenerateToken(usuario.FirstOrDefault());
                return Ok(new { token = token, usuario = usuario });

            }
            catch (Exception e)
            {
                return new BadRequestObjectResult(new { e.Message });
            }
        }
    }

    public class LoginBody
    {
        public string email { get; set; }
        public string senha { get; set; }
    }
}
