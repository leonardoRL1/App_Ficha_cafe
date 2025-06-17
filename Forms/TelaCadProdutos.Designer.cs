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
            produtoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            dataGridView1.Location = new Point(124, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(544, 449);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.RowValidated += dataGridView1_RowValidated;
            dataGridView1.RowHeadersVisible = false;

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
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 450);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Ficha_cafe.Models.Produto);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaCadProdutos";
            StartPosition = FormStartPosition.Manual;
            Text = "TelaCadProdutos";
            Load += TelaCadProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        }
    }