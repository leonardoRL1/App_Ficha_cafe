using GFCafe.Properties;

namespace GFCafe.Forms
    {
    partial class TelaHistorico
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHistorico));
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBackMenu = new Button();
            btnDeletar = new Button();
            btnEditar = new Button();
            btnFiltrar = new Button();
            DataInicial = new DateTimePicker();
            labelFiltros = new Label();
            panel1 = new Panel();
            comboBoxNome = new ComboBox();
            btnConfirmar = new Button();
            labelNome = new Label();
            labelData = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.InactiveCaption;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = SystemColors.InactiveCaption;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(670, 448);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnBackMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDeletar, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFiltrar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(674, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(126, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnBackMenu
            // 
            btnBackMenu.BackColor = SystemColors.Window;
            btnBackMenu.Dock = DockStyle.Fill;
            btnBackMenu.FlatAppearance.BorderSize = 0;
            btnBackMenu.FlatStyle = FlatStyle.Flat;
            btnBackMenu.Location = new Point(0, 0);
            btnBackMenu.Margin = new Padding(0);
            btnBackMenu.Name = "btnBackMenu";
            btnBackMenu.Size = new Size(126, 112);
            btnBackMenu.TabIndex = 0;
            btnBackMenu.Text = "Voltar\r\nMenu";
            btnBackMenu.UseVisualStyleBackColor = false;
            btnBackMenu.Click += btnBackMenu_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Sienna;
            btnDeletar.Dock = DockStyle.Fill;
            btnDeletar.FlatAppearance.BorderSize = 0;
            btnDeletar.FlatStyle = FlatStyle.Flat;
            btnDeletar.ForeColor = SystemColors.ButtonHighlight;
            btnDeletar.Location = new Point(0, 336);
            btnDeletar.Margin = new Padding(0);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(126, 114);
            btnDeletar.TabIndex = 1;
            btnDeletar.Text = "Coming Soon";
            btnDeletar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Sienna;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(0, 112);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 112);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Coming Soon";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = SystemColors.Window;
            btnFiltrar.Dock = DockStyle.Fill;
            btnFiltrar.FlatAppearance.BorderSize = 0;
            btnFiltrar.FlatStyle = FlatStyle.Flat;
            btnFiltrar.Location = new Point(0, 224);
            btnFiltrar.Margin = new Padding(0);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(126, 112);
            btnFiltrar.TabIndex = 3;
            btnFiltrar.Text = "Filtrar\r\nLançamentos";
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // DataInicial
            // 
            DataInicial.AccessibleDescription = "";
            DataInicial.AccessibleName = "";
            DataInicial.CustomFormat = "MM, yyyy";
            DataInicial.Format = DateTimePickerFormat.Custom;
            DataInicial.Location = new Point(6, 155);
            DataInicial.Name = "DataInicial";
            DataInicial.ShowCheckBox = true;
            DataInicial.Size = new Size(118, 23);
            DataInicial.TabIndex = 3;
            DataInicial.ValueChanged += DataInicial_ValueChanged;
            // 
            // labelFiltros
            // 
            labelFiltros.AutoSize = true;
            labelFiltros.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFiltros.ForeColor = SystemColors.ButtonHighlight;
            labelFiltros.Location = new Point(44, 81);
            labelFiltros.Name = "labelFiltros";
            labelFiltros.Size = new Size(39, 15);
            labelFiltros.TabIndex = 5;
            labelFiltros.Text = "Filtros";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(comboBoxNome);
            panel1.Controls.Add(btnConfirmar);
            panel1.Controls.Add(labelNome);
            panel1.Controls.Add(labelData);
            panel1.Controls.Add(labelFiltros);
            panel1.Controls.Add(DataInicial);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 448);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // comboBoxNome
            // 
            comboBoxNome.FormattingEnabled = true;
            comboBoxNome.Location = new Point(6, 224);
            comboBoxNome.Name = "comboBoxNome";
            comboBoxNome.Size = new Size(118, 23);
            comboBoxNome.TabIndex = 9;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(21, 282);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(90, 31);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Filtrar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.ForeColor = SystemColors.ButtonHighlight;
            labelNome.Location = new Point(21, 204);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(62, 15);
            labelNome.TabIndex = 7;
            labelNome.Text = "Por nome:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelData.ForeColor = SystemColors.ButtonHighlight;
            labelData.Location = new Point(21, 137);
            labelData.Name = "labelData";
            labelData.Size = new Size(53, 15);
            labelData.TabIndex = 6;
            labelData.Text = "Por mês:";
            // 
            // TelaHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TelaHistorico";
            StartPosition = FormStartPosition.Manual;
            Text = "TelaHistorico";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBackMenu;
        private Button btnDeletar;
        private Button btnEditar;
        private Button btnFiltrar;
        private DateTimePicker DataInicial;
        private Label labelFiltros;
        private Panel panel1;
        private Label labelNome;
        private Label labelData;
        private Button btnConfirmar;
        private ComboBox comboBoxNome;
        }
    }