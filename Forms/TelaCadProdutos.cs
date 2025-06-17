using Ficha_cafe;
using Ficha_cafe.Models;
using GFCafe.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFCafe.Forms
{
    public partial class TelaCadProdutos : Form
        {
        private IEnumerable<Produto> produtosList;
        public TelaCadProdutos()
            {
            InitializeComponent();
            CarregarGrid();
            //this.FormClosed += Form_FormClosed;
            }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
            {
            Application.Exit();
            }

        private void TelaCadProdutos_Load(object sender, EventArgs e)
            {

            }

        private void CarregarGrid()
            {
            var produtos = new ProdutoRepository().ReadProdutos();
            produtosList = new BindingList<Produto>(produtos.ToList());
            dataGridView1.DataSource = produtosList;
            dataGridView1.Columns["Id"].Width = 30;
            dataGridView1.Columns["Nome"].Width = 150;
            dataGridView1.Columns["Preco"].Width = 50;
            dataGridView1.Columns["Estoque"].Width = 50;

            if (dataGridView1.Columns["Id"] != null)
                {
                dataGridView1.Columns["Id"].ReadOnly = true;
                }
            }

        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
            {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.DataBoundItem is Produto produto)
                {
                var update = new ProdutoRepository();
                update.UpdateProduto(produto);
                }
            }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e) // botao voltar menu
            {
            Ficha_cafe.Menu menu = new Ficha_cafe.Menu();
            this.Close();
            }

        private int getIdRow(int rowIndex)
            {
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                var idValue = row.Cells["Id"].Value;
                if (idValue != null && int.TryParse(idValue.ToString(), out int id))
                    {
                    return id;
                    }
                }
            return -1; // ou lance uma exceção, se preferir
            }

        #region Editar Produto
        private int getIdSelecionado() => (int)dataGridView1.CurrentRow.Cells["Id"].Value;
        private void editarProduto() => editarProduto(getIdSelecionado());
        private void btnEditar_Click(object sender, EventArgs e) => editarProduto();
        private void editarProduto(int id)
            {
            if (id <= 0) return;
            MessageBox.Show($"Editar funcionando, id do produto: {id}");
            }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
            editarProduto();
            }
        #endregion

        private void DeletarLancamento(int id)
            {
            if (id <= 0) return;
            MessageBox.Show("Editar funcionando");
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        }

    }
