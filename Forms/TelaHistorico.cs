using Ficha_cafe;
using Ficha_cafe.Models;
using GFCafe.Models;
using GFCafe.Repositories;
using GFCafe.Repository;
using System.ComponentModel;
using System.Runtime.InteropServices.Marshalling;

namespace GFCafe.Forms
{
    public partial class TelaHistorico : Form
    {
        private BindingList<ViewMov> historicoList;

        public TelaHistorico()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            var historico = new ViewMovRepository().ReadViewMov();
            historicoList = new BindingList<ViewMov>(historico.ToList());
            dataGridView1.DataSource = historicoList;
            ConfigColunas();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
        }

        private void DataInicial_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nomeSelecionado = comboBoxNome.SelectedItem as string;
            if (string.IsNullOrEmpty(nomeSelecionado))
                nomeSelecionado = "Todos";

            bool filtrarPorNome = nomeSelecionado != "Todos";
            bool filtrarPorMes = DataInicial.Checked;

            IEnumerable<ViewMov> historico;

            if (filtrarPorNome && filtrarPorMes)
                historico = FiltrarPorNomeMes();
            else if (filtrarPorNome)
                historico = FiltrarPorNome();
            else if (filtrarPorMes)
                historico = FiltrarPorMes();
            else
                historico = new ViewMovRepository().ReadViewMov();

            dataGridView1.DataSource = new BindingList<ViewMov>(historico.ToList());
            panel1.Visible = false;
            }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!panel1.Visible)
            {
                CarregarNomesComboBox();
                DataInicial.Checked = false;
            }

            panel1.Visible = !panel1.Visible;
        }

        private IEnumerable<ViewMov> FiltrarPorMes()
            {
            int mes = DataInicial.Value.Month;
            int ano = DataInicial.Value.Year;

            return new ViewMovRepository().ReadViewMovByMonth(mes, ano);
            }

        private IEnumerable<ViewMov> FiltrarPorNome()
            {
            string nomeSelecionado = comboBoxNome.SelectedItem as string;

            if (string.IsNullOrEmpty(nomeSelecionado))
                nomeSelecionado = "Todos";

            return new ViewMovRepository().ReadViewMovByFunc(nomeSelecionado);
            }
        private IEnumerable<ViewMov> FiltrarPorNomeMes()
            {
            string nomeSelecionado = comboBoxNome.SelectedItem as string;
            if (string.IsNullOrEmpty(nomeSelecionado))
                nomeSelecionado = "Todos";
            int mes = DataInicial.Value.Month;
            int ano = DataInicial.Value.Year;
            return new ViewMovRepository().ReadViewMovByNomeMesAno(nomeSelecionado, mes, ano);
            }

        private void CarregarNomesComboBox()
            {
            var nomes = new ViewMovRepository().ReadViewFunc().ToList();
            nomes.Insert(0, "Todos");
            comboBoxNome.DataSource = nomes;
            comboBoxNome.SelectedIndex = 0;
            }
        private void ConfigColunas()
            {
            dataGridView1.Columns["Id"].Width = 30;
            dataGridView1.Columns["Usuario"].Width = 100;
            dataGridView1.Columns["Funcionario"].Width = 100;
            dataGridView1.Columns["Produto"].Width = 150;
            dataGridView1.Columns[columnName: "Qnt"].Width = 30;
            dataGridView1.Columns[columnName: "PreCoUN"].Width = 60;
            dataGridView1.Columns["PrecoTotal"].Width = 65;
            dataGridView1.Columns["Data"].Width = 100;
            }
    }
}
