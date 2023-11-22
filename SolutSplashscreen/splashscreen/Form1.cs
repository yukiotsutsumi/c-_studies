using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splashscreen
{
    public partial class splash_screen : Form
    {

        public splash_screen()
        {
            InitializeComponent();
        }
       
        private void tempo_Tick(object sender, EventArgs e)
        {
            if (barraProgresso.Value < 100)
            {
                lbl_tempo.Text = barraProgresso.Value + "%";
                barraProgresso.Value = barraProgresso.Value + 5;
                if (barraProgresso.Value > 20)
                {
                    wow.Visible = true;
                }
                if (barraProgresso.Value > 40)
                {
                    such.Visible = true;
                }
                if (barraProgresso.Value > 60)
                {
                    much.Visible = true;
                }
                if (barraProgresso.Value > 80)
                {
                    dezbarradez.Visible = true;
                }
            }
            else
            {
                lbl_tempo.BackColor = Color.Transparent;
                tempo.Enabled = false;
                this.Visible = false;
                login login = new login();
                login.ShowDialog(); 
            }
       }

        private void pct_logo_Click(object sender, EventArgs e)
        {

        }

        private void splash_screen_Load(object sender, EventArgs e)
        {
            wow.Visible = false;
            such.Visible = false;
            much.Visible = false;
            dezbarradez.Visible = false;
            this.Opacity = 30;
        }
    }
}
