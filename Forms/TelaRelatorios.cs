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
    public partial class TelaRelatorios : Form
        {
        public TelaRelatorios()
            {
            InitializeComponent();
            this.FormClosed += Form_FormClosed;
            }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
            {
            Application.Exit();
            }

        private void TelaRelatorios_Load(object sender, EventArgs e)
            {

            }
        }
    }
