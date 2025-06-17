using GFCafe.Forms;
using System.Windows.Forms;

namespace Ficha_cafe
{
    public partial class Menu : Form
        {
        public Menu()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {

            }

        private void btnMenu1_Click(object sender, EventArgs e) // botao historico
            {
            this.Hide();
            TelaHistorico telaHistorico = new TelaHistorico();
            // Ao fechar a tela de histórico, mostrar novamente o menu principal
            telaHistorico.FormClosed += (s, args) => this.Show();
            telaHistorico.Show();
            }

        private void btnMenu2_Click(object sender, EventArgs e) // botao registra mov
            {
            this.Hide();
            TelaRegistraMov telaRegistraMov = new TelaRegistraMov();
            telaRegistraMov.FormClosed += (s, args) => this.Show();
            telaRegistraMov.Show();
            }

        private void btnMenu3_Click(object sender, EventArgs e) // botao relatorios
            {
            this.Hide();
            TelaRelatorios telaRelatorios = new TelaRelatorios();
            telaRelatorios.FormClosed += (s, args) => this.Show();
            telaRelatorios.Show();
            }

        private void btnMenu4_Click(object sender, EventArgs e) // botao cad produtos
            {
            this.Hide();
            TelaCadProdutos telaCadProdutos = new TelaCadProdutos();
            // Ao fechar a tela de cadastro de produtos, mostrar novamente o menu principal
            telaCadProdutos.FormClosed += (s, args) => this.Show();
            telaCadProdutos.Show();
            }

        private void button1_Click(object sender, EventArgs e) // botao menu
            {

            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {
            
            }
        }
    }
