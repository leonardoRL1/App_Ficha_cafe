using Ficha_cafe;
using Ficha_cafe.Models;
using GFCafe.Repository;
using System.ComponentModel;

namespace GFCafe.Forms
{
    public partial class TelaCadProdutos : Form
        {
        private BindingList<Produto> produtosList;

        public TelaCadProdutos()
            {
            InitializeComponent();
            CarregarGrid();
            }

        private void CarregarGrid()
            {
            var produtos = new ProdutoRepository().ReadProdutos();
            produtosList = new BindingList<Produto>(produtos.ToList());
            dataGridView1.DataSource = produtosList;
            dataGridView1.Columns["Id"].Width = 30;
            dataGridView1.Columns["Nome"].Width = 150;
            dataGridView1.Columns["Preco"].Width = 60;
            dataGridView1.Columns["Estoque"].Width = 60;
            }

        private void button1_Click(object sender, EventArgs e) // botao voltar menu
            {
            Menu menu = new Menu();
            this.Close();
            }

        private int getIdSelecionado() => (int)dataGridView1.CurrentRow.Cells["Id"].Value;

        private void MostrarProduto() => MostrarProduto(getIdSelecionado());

        private void MostrarProduto(int id)
            {
            if (id <= 0) return;
            var produto = produtosList.FirstOrDefault(p => p.Id == id);

            txtNome.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString("F2");
            txtEstoque.Text = produto.Estoque.ToString();
            checkControlaEstoque.Checked = produto.ControlaEstoque;

            panel1.Visible = !panel1.Visible;
            }

        private void LimparCampos()
            {
            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            checkControlaEstoque.Checked = false;
            }

        private bool PermiteEditarTxt()
            {
            bool permite;
            if (labelTitulo.Text == "Editar" || labelTitulo.Text == "Adicionar")
                {
                txtNome.ReadOnly = false;
                txtPreco.ReadOnly = false;
                txtEstoque.ReadOnly = false;
                checkControlaEstoque.Enabled = true;
                permite = true;
                }

            else // Ultimo botao == "Excluir"
                {
                txtNome.ReadOnly = true;
                txtPreco.ReadOnly = true;
                txtEstoque.ReadOnly = true;
                checkControlaEstoque.Enabled = false;
                checkControlaEstoque.Visible = false;
                permite = false;
                }

            return permite;
            }

        private void btnEditar_Click(object sender, EventArgs e)
            {
            labelTitulo.Text = "Editar";
            PermiteEditarTxt();
            MostrarProduto();
            }

        private void btnAdicionar_Click(object sender, EventArgs e)
            {
            labelTitulo.Text = "Adicionar";
            PermiteEditarTxt();
            LimparCampos();
            panel1.Visible = !panel1.Visible;
            }

        private void btnDeletar_Click(object sender, EventArgs e)
            {
            labelTitulo.Text = "Excluir";
            PermiteEditarTxt();
            MostrarProduto();
            }

        private void btnConfirmar_Click(object sender, EventArgs e)
            {
            if (!isValid()) return;

            ProdutoRepository produtoRepository = new ProdutoRepository();

            switch (labelTitulo.Text)
                {
            case "Editar":
                EditarProduto();
                break;
            case "Adicionar":
                AdicionarProduto();
                break;
            case "Excluir":
                ExcluirProduto();
                break;
                }

            panel1.Visible = false;
            CarregarGrid();
            }

        private void EditarProduto()
            {
            int id = getIdSelecionado();
            var produto = produtosList.FirstOrDefault(p => p.Id == id);
            if (produto == null) return;

            produto.Nome = txtNome.Text;
            produto.Preco = decimal.Parse(txtPreco.Text);
            produto.Estoque = int.Parse(txtEstoque.Text);
            produto.ControlaEstoque = checkControlaEstoque.Checked;

            new ProdutoRepository().UpdateProduto(produto);
            }

        private void AdicionarProduto()
            {
            var novoProduto = new Produto
                {
                Nome = txtNome.Text,
                Preco = decimal.Parse(txtPreco.Text),
                Estoque = int.Parse(txtEstoque.Text),
                ControlaEstoque = checkControlaEstoque.Checked
                };
            new ProdutoRepository().CreateProduto(novoProduto);
            }

        private void ExcluirProduto()
            {
            int id = getIdSelecionado();
            if (id <= 0) return;
            new ProdutoRepository().DeleteProduto(id);
            }

        private bool isValid()
            {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtEstoque.Text))
                {
                MessageBox.Show("Preencha todos os campos!");
                return false;
                }
            return true;
            }
        }
    }
