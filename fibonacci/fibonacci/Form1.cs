using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vbase = 2;
            int vexp = 4;
           

            int potencia = vbase;
            txtExp.Text = potencia.ToString();
            int cont = 1;
            while (cont < vexp) 
            {
                potencia = potencia * vbase;
                txtExp.Text = txtExp.Text + "," + potencia;
                cont = cont + cont;
                
            }
        }

