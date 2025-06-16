using MySql.Data.MySqlClient;
using System.Data;

public sealed class MySqlConnectionFactory
    {
    private static readonly Lazy<MySqlConnectionFactory> _instance =
        new(() => new MySqlConnectionFactory());

    private readonly string _connectionString;

    private MySqlConnectionFactory()
        {
        _connectionString = "server=192.168.253.107; database=ficha_cafe; user=root; password=root;";
        }

    public static MySqlConnectionFactory Instance => _instance.Value;

    public IDbConnection GetConnection()
        {
        var connection = new MySqlConnection(_connectionString);
        connection.Open();
        return connection;
        }
    }
