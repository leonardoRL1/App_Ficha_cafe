using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GFCafe.Models;

namespace GFCafe.Repositories
    {
    public class ViewMovRepository
    {
        public IEnumerable<ViewMov> ReadViewMov()
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            return connection.Query<ViewMov>("SELECT * " +
                                                "FROM vw_historico " +
                                                "ORDER BY Id DESC");
        }

        public IEnumerable<string> ReadViewFunc()
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            return connection.Query<string>("SELECT DISTINCT Funcionario " +
                                                "FROM vw_historico " +
                                                "ORDER BY Funcionario;");
        }

        public IEnumerable<ViewMov> ReadViewMovByFunc(string funcionario)
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = @"SELECT *
                              FROM vw_historico
                              WHERE @Funcionario = 'Todos'
                              OR Funcionario = @Funcionario
                              ORDER BY Id DESC;";
            return connection.Query<ViewMov>(sql, new { Funcionario = funcionario});
        }

        public IEnumerable<ViewMov> ReadViewMovByMonth(int mes, int ano)
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = @"SELECT *
                              FROM vw_historico
                              WHERE MONTH(Data) = @Mes
                              AND YEAR(Data) = @Ano
                              ORDER BY Id DESC;";
            return connection.Query<ViewMov>(sql, new {Mes = mes, Ano = ano});
        }
        public IEnumerable<ViewMov> ReadViewMovByNomeMesAno(string funcionario, int mes, int ano)
            {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = @"SELECT *
                              FROM vw_historico
                              WHERE @Funcionario = 'Todos' OR Funcionario = @Funcionario
                              AND MONTH(Data) = @Mes
                              AND YEAR(Data) = @Ano
                              ORDER BY Id DESC;";
            return connection.Query<ViewMov>(sql, new { Funcionario = funcionario, Mes = mes, Ano = ano });
            }
        }
}
