using Dapper;
using Dapper.Contrib.Extensions;
using Ficha_cafe.Models;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace GFCafe.Repository
{
public class UsuarioRepository
    {
    public IEnumerable<Usuario> GetUsuarios()
        {
        using var connection = MySqlConnectionFactory.Instance.CreateConnection();
        return connection.Query<Usuario>("SELECT * FROM usuarios");
        }
    }
}