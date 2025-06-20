namespace GFCafe.Forms
    {
    partial class TelaRegistraMov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRegistraMov));
            comboFuncionario = new ComboBox();
            comboProduto = new ComboBox();
            comboUsuario = new ComboBox();
            panel1 = new Panel();
            txtPrecoTotal = new TextBox();
            txtPrecoUN = new TextBox();
            txtQnt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBackMenu = new Button();
            btnEditar = new Button();
            btnFinalizar = new Button();
            label2 = new Label();
            label1 = new Label();
            labelTime = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboFuncionario
            // 
            comboFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new Point(354, 96);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new Size(121, 23);
            comboFuncionario.TabIndex = 1;
            // 
            // comboProduto
            // 
            comboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            comboProduto.FormattingEnabled = true;
            comboProduto.Location = new Point(176, 168);
            comboProduto.Name = "comboProduto";
            comboProduto.Size = new Size(164, 23);
            comboProduto.TabIndex = 2;
            comboProduto.SelectedIndexChanged += comboProduto_SelectedIndexChanged;
            // 
            // comboUsuario
            // 
            comboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            comboUsuario.FormattingEnabled = true;
            comboUsuario.Location = new Point(176, 96);
            comboUsuario.Name = "comboUsuario";
            comboUsuario.Size = new Size(121, 23);
            comboUsuario.TabIndex = 0;
            comboUsuario.Tag = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(txtPrecoTotal);
            panel1.Controls.Add(txtPrecoUN);
            panel1.Controls.Add(txtQnt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTime);
            panel1.Controls.Add(comboFuncionario);
            panel1.Controls.Add(comboUsuario);
            panel1.Controls.Add(comboProduto);
            panel1.Location = new Point(-1, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 359);
            panel1.TabIndex = 5;
            // 
            // txtPrecoTotal
            // 
            txtPrecoTotal.Location = new Point(354, 239);
            txtPrecoTotal.Name = "txtPrecoTotal";
            txtPrecoTotal.ReadOnly = true;
            txtPrecoTotal.Size = new Size(121, 23);
            txtPrecoTotal.TabIndex = 15;
            // 
            // txtPrecoUN
            // 
            txtPrecoUN.Location = new Point(176, 239);
            txtPrecoUN.Name = "txtPrecoUN";
            txtPrecoUN.ReadOnly = true;
            txtPrecoUN.Size = new Size(121, 23);
            txtPrecoUN.TabIndex = 14;
            // 
            // txtQnt
            // 
            txtQnt.Location = new Point(394, 168);
            txtQnt.Name = "txtQnt";
            txtQnt.Size = new Size(81, 23);
            txtQnt.TabIndex = 13;
            txtQnt.TextChanged += txtQnt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(394, 150);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 12;
            label6.Text = "Quantidade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(227, 150);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Produto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(376, 78);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "Funcionário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(176, 78);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 9;
            label3.Text = "Usuário Registrador";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnBackMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEditar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFinalizar, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Right;
            tableLayoutPanel1.Location = new Point(678, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(126, 359);
            tableLayoutPanel1.TabIndex = 8;
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
            btnBackMenu.Size = new Size(126, 119);
            btnBackMenu.TabIndex = 0;
            btnBackMenu.Text = "Voltar\r\nMenu";
            btnBackMenu.UseVisualStyleBackColor = false;
            btnBackMenu.Click += btnBackMenu_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Sienna;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = SystemColors.ButtonHighlight;
            btnEditar.Location = new Point(0, 119);
            btnEditar.Margin = new Padding(0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(126, 119);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Coming Soon";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = SystemColors.Window;
            btnFinalizar.Dock = DockStyle.Fill;
            btnFinalizar.FlatAppearance.BorderSize = 0;
            btnFinalizar.FlatStyle = FlatStyle.Flat;
            btnFinalizar.Location = new Point(0, 238);
            btnFinalizar.Margin = new Padding(0);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(126, 121);
            btnFinalizar.TabIndex = 3;
            btnFinalizar.Text = "Registrar";
            btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(376, 218);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Preço Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(190, 218);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 6;
            label1.Text = "Preço Unidade:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = SystemColors.ButtonHighlight;
            labelTime.Location = new Point(36, 30);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(32, 15);
            labelTime.TabIndex = 5;
            labelTime.Text = "Data";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // TelaRegistraMov
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TelaRegistraMov";
            StartPosition = FormStartPosition.Manual;
            Text = "TelaRegistraMov";
            Load += TelaRegistraMov_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion

        private ComboBox comboFuncionario;
        private ComboBox comboProduto;
        private ComboBox comboUsuario;
        private Panel panel1;
        private Label labelTime;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBackMenu;
        private Button btnEditar;
        private Button btnFinalizar;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtQnt;
        private TextBox txtPrecoTotal;
        private TextBox txtPrecoUN;
        private System.Windows.Forms.Timer timer1;
        }
    }