using Dapper;
using Ficha_cafe.Models;
using System.Data;

public class UsuarioRepository
    {
    public IEnumerable<Usuario> GetUsuarios()
        {
        using var connection = MySqlConnectionFactory.Instance.GetConnection();
        return connection.Query<Usuario>("SELECT * FROM usuarios");
        }
    }
