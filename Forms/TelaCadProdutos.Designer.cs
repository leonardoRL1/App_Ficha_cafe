namespace GFCafe.Forms
    {
    partial class TelaCadProdutos
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadProdutos));
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBackMenu = new Button();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            panel1 = new Panel();
            labelTitulo = new Label();
            labelProdEstoque = new Label();
            labelProdPreco = new Label();
            labelProdNome = new Label();
            checkControlaEstoque = new CheckBox();
            txtEstoque = new TextBox();
            txtPreco = new TextBox();
            txtNome = new TextBox();
            btnConfirmar = new Button();
            produtoBindingSource = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.Sienna;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(182, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(418, 449);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnBackMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDeletar, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnAdicionar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(674, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(126, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBackMenu
            // 
            btnBackMenu.BackColor = SystemColors.InactiveCaption;
            btnBackMenu.Dock = DockStyle.Fill;
            btnBackMenu.Location = new Point(0, 0);
            btnBackMenu.Margin = new Padding(0);
            btnBackMenu.Name = "btnBackMenu";
            btnBackMenu.Size = new Size(126, 112);
            btnBackMenu.TabIndex = 0;
            btnBackMenu.Text = "Voltar\r\nMenu";
            btnBackMenu.UseVisualStyleBackColor = false;
            btnBackMenu.Click += button1_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Sienna;
            btnDeletar.Dock = DockStyle.Fill;
            btnDeletar.ForeColor = SystemColors.ButtonHighlight;
            btnDeletar.Location = new Point(0, 336);
            btnDeletar.Margin = new Padding(0);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(126, 114);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Remover\r\nProduto";
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Sienna;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(0, 112);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 112);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar\r\nProduto";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = SystemColors.InactiveCaption;
            btnAdicionar.Dock = DockStyle.Fill;
            btnAdicionar.Location = new Point(0, 224);
            btnAdicionar.Margin = new Padding(0);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(126, 112);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar\r\nProduto";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(labelProdEstoque);
            panel1.Controls.Add(labelProdPreco);
            panel1.Controls.Add(labelProdNome);
            panel1.Controls.Add(checkControlaEstoque);
            panel1.Controls.Add(txtEstoque);
            panel1.Controls.Add(txtPreco);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(btnConfirmar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 450);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(47, 37);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(38, 15);
            labelTitulo.TabIndex = 6;
            labelTitulo.Text = "Titulo";
            // 
            // labelProdEstoque
            // 
            labelProdEstoque.AutoSize = true;
            labelProdEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdEstoque.Location = new Point(26, 203);
            labelProdEstoque.Name = "labelProdEstoque";
            labelProdEstoque.Size = new Size(75, 15);
            labelProdEstoque.TabIndex = 5;
            labelProdEstoque.Text = "Estoque Qnt.";
            // 
            // labelProdPreco
            // 
            labelProdPreco.AutoSize = true;
            labelProdPreco.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdPreco.Location = new Point(47, 140);
            labelProdPreco.Name = "labelProdPreco";
            labelProdPreco.Size = new Size(37, 15);
            labelProdPreco.TabIndex = 4;
            labelProdPreco.Text = "Preço";
            // 
            // labelProdNome
            // 
            labelProdNome.AutoSize = true;
            labelProdNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProdNome.Location = new Point(47, 81);
            labelProdNome.Name = "labelProdNome";
            labelProdNome.Size = new Size(40, 15);
            labelProdNome.TabIndex = 3;
            labelProdNome.Text = "Nome";
            // 
            // checkControlaEstoque
            // 
            checkControlaEstoque.AutoSize = true;
            checkControlaEstoque.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkControlaEstoque.Location = new Point(12, 270);
            checkControlaEstoque.Name = "checkControlaEstoque";
            checkControlaEstoque.Size = new Size(116, 19);
            checkControlaEstoque.TabIndex = 2;
            checkControlaEstoque.Text = "Controla Estoque";
            checkControlaEstoque.UseVisualStyleBackColor = true;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(12, 221);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(112, 23);
            txtEstoque.TabIndex = 1;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 158);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(112, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(112, 23);
            txtNome.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(26, 320);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 0;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Ficha_cafe.Models.Produto);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // TelaCadProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadProdutos";
            Text = "TelaCadProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)produtoBindingSource).EndInit();
            ResumeLayout(false);
            }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn controlaEstoqueDataGridViewCheckBoxColumn;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBackMenu;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnAdicionar;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private BindingSource produtoBindingSource;
        private TextBox txtNome;
        private Button btnConfirmar;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox txtPreco;
        private CheckBox checkControlaEstoque;
        private TextBox txtEstoque;
        private Label labelProdNome;
        private Label labelProdEstoque;
        private Label labelProdPreco;
        private Label labelTitulo;
        }
    }