using Dapper;
using Ficha_cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFCafe.Repositories
    {
    public class MovimentacaoRepository
        {
        public IEnumerable<Movimentacao> ReadMovimentacao()
            {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            return connection.Query<Movimentacao>("SELECT * FROM tbl_movimentacao ORDER BY Id DESC");
            }
        }
    }
