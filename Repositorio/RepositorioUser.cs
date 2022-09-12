using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication3.Models;

namespace WebApplication3.Repositorio
{

    public interface IrepositorioUser
    {
        void Crear(user user);
    }
    public class RepositorioUser : IrepositorioUser
    {

        private readonly string ConnectionStrings;
        public RepositorioUser(IConfiguration configuration)
        {
            ConnectionStrings = configuration.GetConnectionString("DefaultConnection");
        }

        public  void Crear(user user)
        {
            using var connection = new SqlConnection(ConnectionStrings);
            var id = connection.QuerySingle<int>($@"INSERT INTO [dbo].[User] (Age, [Name], Career) 
                                                    VALUES (@Age, @Name, @Career); 
                                                    SELECT SCOPE_IDENTITY();", user);

            user.Id = id;
        }
    }
}
