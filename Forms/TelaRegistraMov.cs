using Ficha_cafe;
using Ficha_cafe.Models;
using GFCafe.Repositories;
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
    public partial class TelaRegistraMov : Form
        {
        public TelaRegistraMov()
            {
            InitializeComponent();
            CarregarCombos();
            }

        private void btnBackMenu_Click(object sender, EventArgs e)
            {
            Menu menu = new Menu();
            this.Close();
            }

        private void CarregarCombos()
            {
            var usuarioRepo = new UsuarioRepository();
            comboUsuario.ValueMember = "Id";
            comboUsuario.DisplayMember = "Nome";
            comboUsuario.DataSource = usuarioRepo.ReadUsuarios().ToList();
            comboUsuario.SelectedIndex = -1;

            var funcionarioRepo = new FuncionarioRepository();
            comboFuncionario.ValueMember = "Id";
            comboFuncionario.DisplayMember = "Nome";
            comboFuncionario.DataSource = funcionarioRepo.ReadFuncionarios().ToList();
            comboFuncionario.SelectedIndex = -1;

            var nomeProduto = new ProdutoRepository();
            comboProduto.ValueMember = "Id";
            comboProduto.DisplayMember = "Nome";
            comboProduto.DataSource = nomeProduto.ReadProdutos().ToList();
            comboProduto.SelectedIndex = -1;
            }
        private void CalculaPreco()
            {
            if (comboProduto.SelectedItem is Produto produto && !string.IsNullOrWhiteSpace(txtQnt.Text))
                {
                txtPrecoUN.Text = produto.Preco.ToString("F2");
                txtPrecoTotal.Text = (produto.Preco * int.Parse(txtQnt.Text)).ToString("F2");
                }
            else
                {
                txtPrecoUN.Text = string.Empty;
                txtPrecoTotal.Text = string.Empty;
                }
            }

        private void comboProduto_SelectedIndexChanged(object sender, EventArgs e)
            {
            CalculaPreco();
            }

        private void txtQnt_TextChanged(object sender, EventArgs e)
            {
            CalculaPreco();
            }

        private void TelaRegistraMov_Load(object sender, EventArgs e)
            {
            timer1.Interval = 1000;
            //timer1.Start();
            }
        private void timer1_Tick(object sender, EventArgs e)
            {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
    }
