using Dapper;
using Ficha_cafe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFCafe.Repository
    {
    public class ProdutoRepository
        {
        public int CreateProduto(Produto produto)
            {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = "INSERT INTO tbl_produtos (Nome, Preco, Estoque, ControlaEstoque) VALUES (@Nome, @Preco, @Estoque, @ControlaEstoque); SELECT LAST_INSERT_ID();";
            return connection.QuerySingle<int>(sql, produto);
            }
        public IEnumerable<Produto> ReadProdutos()
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            return connection.Query<Produto>("SELECT * FROM tbl_produtos");
        }
        public bool UpdateProduto(Produto produto)
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = "UPDATE tbl_produtos SET Nome = @Nome, Preco = @Preco, Estoque = @Estoque, ControlaEstoque = @ControlaEstoque WHERE Id = @Id";
            return connection.Execute(sql, produto) > 0;
        }
        public bool DeleteProduto(int id)
        {
            using var connection = MySqlConnectionFactory.Instance.CreateConnection();
            var sql = "DELETE FROM tbl_produtos WHERE Id = @Id";
            return connection.Execute(sql, new { Id = id }) > 0;
            }
        } 
}
