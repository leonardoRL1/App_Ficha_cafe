using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha_cafe.Models
    {
    public class Movimentacao
        {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int FuncionarioId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUn { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime DataMov { get; set; }
        public DateTime DataUpdate { get; set; }
        public DateTime DataDelete { get; set; }
        }
    }
