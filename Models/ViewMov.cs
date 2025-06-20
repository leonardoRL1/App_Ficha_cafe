using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFCafe.Models
    {
    public class ViewMov
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Funcionario { get; set; }
        public string Produto { get; set; }
        public int Qnt { get; set; }
        public decimal PrecoUN { get; set; }
        public decimal PrecoTotal { get; set; }
        public DateTime Data { get; set; }
    }
}
