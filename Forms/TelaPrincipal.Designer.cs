namespace Ficha_cafe
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnHistorico = new Button();
            btnRegistrar = new Button();
            btnRelatorios = new Button();
            btnCadProduto = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnMenu = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnHistorico
            // 
            btnHistorico.BackColor = Color.Sienna;
            btnHistorico.Dock = DockStyle.Fill;
            btnHistorico.ForeColor = SystemColors.Window;
            btnHistorico.Location = new Point(400, 0);
            btnHistorico.Margin = new Padding(0);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(200, 145);
            btnHistorico.TabIndex = 1;
            btnHistorico.Text = "Histórico";
            btnHistorico.UseVisualStyleBackColor = false;
            btnHistorico.Click += btnMenu1_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ButtonFace;
            btnRegistrar.Dock = DockStyle.Fill;
            btnRegistrar.ForeColor = SystemColors.ControlText;
            btnRegistrar.Location = new Point(200, 0);
            btnRegistrar.Margin = new Padding(0);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(200, 145);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar\r\nConsumo";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnMenu2_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.BackColor = Color.Sienna;
            btnRelatorios.Dock = DockStyle.Fill;
            btnRelatorios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRelatorios.ForeColor = SystemColors.Window;
            btnRelatorios.Location = new Point(0, 0);
            btnRelatorios.Margin = new Padding(0);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(200, 145);
            btnRelatorios.TabIndex = 1;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = false;
            btnRelatorios.Click += btnMenu3_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.BackColor = SystemColors.ButtonFace;
            btnCadProduto.Dock = DockStyle.Fill;
            btnCadProduto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadProduto.Location = new Point(600, 0);
            btnCadProduto.Margin = new Padding(0);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(200, 145);
            btnCadProduto.TabIndex = 1;
            btnCadProduto.Text = "Cadastrar\r\nProduto";
            btnCadProduto.UseVisualStyleBackColor = false;
            btnCadProduto.Click += btnMenu4_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnRegistrar, 1, 0);
            tableLayoutPanel1.Controls.Add(btnRelatorios, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCadProduto, 3, 0);
            tableLayoutPanel1.Controls.Add(btnHistorico, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 305);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 145);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(309, 37);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(180, 64);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenu);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            Text = "Gerenciador de Fichas de Café";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            }

        #endregion
        private Button btnHistorico;
        private Button btnRegistrar;
        private Button btnRelatorios;
        private Button btnCadProduto;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnMenu;
        
        }
}
