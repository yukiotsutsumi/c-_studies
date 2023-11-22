using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projCalculo_do_IMC
{
    public partial class formIMC : Form
    {
        double peso, altura, num, altura2;
        decimal valor = 0;
        decimal valor1 = 0;
        public formIMC()
        {
            InitializeComponent();
        }
        private void Calcular()
        {
            valor = Convert.ToDecimal(txtaltura.Text);
            txtaltura.Text = valor.ToString("N2");
            valor1 = Convert.ToDecimal(txtPeso.Text);
            txtPeso.Text = valor1.ToString("N1");
        }
        private void LimparTela()
        {
            txtNome.Clear();
            txtaltura.Clear();
            txtPeso.Clear();
            lblnumero.Text= string.Empty;
            lblclassificacao.Text = string.Empty;
            pcbfoto.Image = null;
        }

        private void formIMC_Load(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lblnumero.Text = string.Empty;
            lblclassificacao.Text = string.Empty;
            if (txtNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Nome é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }
            if (txtaltura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Altura é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtaltura.Focus();
                return;
            }
            if (txtPeso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Peso é obrigatorio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPeso.Focus();
                return;
            }
            Calcular();
            altura = Convert.ToDouble(txtaltura.Text);
            peso = Convert.ToDouble(txtPeso.Text);
            altura2 = Math.Pow(altura, 2);
            num = peso / altura2;
            lblnumero.Text = "O seu IMC é = " + num.ToString();
            if (num <= 18.5)
            {
                lblclassificacao.Text = "Você está abaixo do peso";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.estar_abaixo_do_peso_ideal_tambem_traz_problemas_a_saude_2;
            }
            if (num > 18.6 && num < 24.9)
            {
                lblclassificacao.Text = "Você está saudável";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.images;
            }
            if (num > 25.0 && num < 29.9)
            {
                lblclassificacao.Text = "Você está com peso em excesso";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.download;
            }
            if (num > 30.0 && num < 34.9)
            {
                lblclassificacao.Text = "Você está na obesidade grau I";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.images__1_;
            }
            if (num > 35.0 && num < 39.9)
            {
                lblclassificacao.Text = "Você está na obesidade grau II";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.download__1_;
            }
            if (num > 40)
            {
                lblclassificacao.Text = "Você está na obesidade grau III";
                pcbfoto.Visible = true;
                pcbfoto.Image = Properties.Resources.images__2_;
            }
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            if (e.KeyChar != '\b' && e.KeyChar != '\r' && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.KeyChar = '\0';
            }
        }

        private void lblnumero_Click(object sender, EventArgs e)
        {

        }
    }
}
