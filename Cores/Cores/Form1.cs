using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cores
{
    public partial class Micalateia : Form
    {
        public Micalateia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Azul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void b_Vermelho_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void b_Verde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
    }
}
