using Dapper;
using Ficha_cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFCafe.Repositories
    {
    public class FuncionarioRepository
        {
        public IEnumerable<Funcionario> ReadFuncionarios()
            {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            return connection.Query<Funcionario>("SELECT * FROM tbl_funcionarios");
            }
        }
    }
