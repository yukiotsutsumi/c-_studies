using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double n1 = 0;
            double n2 = 0;
            n1 = double.Parse(txtn1.Text);
            n2 = double.Parse(txtn2.Text);
            if (cboOperador.Text == "+")
            {
                lblresult.Text = n1 + n2 + "";
            }
            else {
                if (cboOperador.Text == "-")
                {
                    lblresult.Text = n1 - n2 + "";
                }
            }
        }
    }
}
