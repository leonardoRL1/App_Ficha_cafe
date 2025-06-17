using MySql.Data.MySqlClient;
using System;

public sealed class MySqlConnectionFactory
    {
    private static readonly Lazy<MySqlConnectionFactory> instance =
        new Lazy<MySqlConnectionFactory>(() => new MySqlConnectionFactory());

    private readonly string connectionString;

    private MySqlConnectionFactory()
        {
        // Ajusta essa string conforme seu banco
        connectionString = "server=192.168.253.107; Port=3307; database=ficha_cafe; uid=root; pwd=root;";
        }

    public static MySqlConnectionFactory Instance => instance.Value;

    public MySqlConnection CreateConnection()
        {
        return new MySqlConnection(connectionString);
        }

    // Método para testar a conexão com o banco de dados
    public bool TesteConnection()
        {
        try
            {
            using var connection = CreateConnection();
            connection.Open();
            return true;
            }
        catch (Exception e)
            {
            Console.WriteLine(e.Message);
            return false;
            }
        }
    }
