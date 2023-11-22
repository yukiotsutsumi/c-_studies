using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ProjHolerite
{
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
            InitializeComponent();
        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            if (barraProgresso.Value < 100)
            {
                lbl_tempo.Text = barraProgresso.Value + "%";
                barraProgresso.Value = barraProgresso.Value + 5;
            }
            else
            {
                lbl_tempo.BackColor = Color.Transparent;
                tempo.Enabled = false;
                this.Visible = false;
                Form_login login = new Form_login();
                login.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
