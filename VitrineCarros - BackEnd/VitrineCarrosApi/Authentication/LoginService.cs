using VitrineCarrosApi.Settings;
using Dapper;
using System.Data.SqlClient;
using VitrineCarrosApi.Models;

namespace VitrineCarrosApi.Authentication
{
    public class LoginService
    {
        public async Task<List<Usuario>> GetUserLogin(string email, string senha)
        {
            try
            {

                SqlConnection connection = new SqlConnection(Connections.identidadeacesso);
                await connection.OpenAsync();
                string sql = $"SELECT * FROM usuario";
                var fato = await connection.QueryAsync<Usuario>(sql);

                var result = fato.Where(x => x.email == email && x.senha == senha).ToList();
                await connection.CloseAsync();

                return result;

            }
            catch (Exception e)
            {
                throw new Exception($"Não foi possível encontrar o usuário, {e.Message}");
            }
        }
    }
}
