using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjHolerite
{
    public partial class Form_Holerite : Form
    {
        private void Form_Holerite_Load(object sender, EventArgs e)
        {
            
        }
        
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                txt_filhos.Visible = true;
            else
                txt_filhos.Visible = false;
        }

        public Form_Holerite()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txt_fds.Visible = true;
            else
                txt_fds.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                txt_dn.Visible = true;
            else
                txt_dn.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                txt_f.Visible = true;
            else
                txt_f.Visible = false;
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {            
            ItensFolha.valor_salario = double.Parse(TxtSalario.Text);
            ItensFolha.Horas_Extras_Dias_Normais = double.Parse(txt_dn.Text);
            ItensFolha.Horas_Extras_FDS = double.Parse(txt_fds.Text);
            ItensFolha.faltas = double.Parse(txt_f.Text);
            ItensFolha.filhos = double.Parse(txt_filhos.Text);
            ItensFolha.valor_Horas_Extras_Dias_Normais = ((ItensFolha.valor_salario / 220) * 1.5) * ItensFolha.Horas_Extras_Dias_Normais;
            ItensFolha.valor_horas_extras_fds = ((ItensFolha.valor_salario / 220) * 2) * ItensFolha.Horas_Extras_FDS;
            ItensFolha.valor_horas_extras = ItensFolha.valor_Horas_Extras_Dias_Normais + ItensFolha.valor_horas_extras_fds;
            ItensFolha.DSR = (ItensFolha.valor_horas_extras / 24) * 6;
            ItensFolha.Valor_desc_Faltas = (ItensFolha.valor_salario / 30) * ItensFolha.faltas;
            ItensFolha.salario_familia = (ItensFolha.valor_salario + ItensFolha.valor_horas_extras + ItensFolha.DSR) - ItensFolha.Valor_desc_Faltas;
            if (ItensFolha.salario_familia <= 725.05)
            {
                ItensFolha.pagar_salario_familia = 37.18 * ItensFolha.filhos;
            }
            else if(ItensFolha.salario_familia >= 725.06 && ItensFolha.salario_familia <= 1089.79)
            {
                ItensFolha.pagar_salario_familia = 26.20 * ItensFolha.filhos;
            }
            ItensFolha.Valor_Inss = (ItensFolha.valor_salario + ItensFolha.valor_horas_extras + ItensFolha.DSR) - ItensFolha.Valor_desc_Faltas;
            if (ItensFolha.Valor_Inss <= 1399.12)
            {
                ItensFolha.Valor_Desc_INSS = ItensFolha.Valor_Inss * 0.08;
            }
            else if (ItensFolha.Valor_Inss >= 1399.13 && ItensFolha.Valor_Inss <= 2331.88)
            {
                ItensFolha.Valor_Desc_INSS = ItensFolha.Valor_Inss * 0.09;
            }
            else if (ItensFolha.Valor_Inss >= 2331.89 && ItensFolha.Valor_Inss <= 4663.75)
            {
                ItensFolha.Valor_Desc_INSS = ItensFolha.Valor_Inss * 0.11;
            }
            else if (ItensFolha.Valor_Inss > 4663.75)
            {
                ItensFolha.Valor_Desc_INSS = ItensFolha.Valor_Inss - 513.01;
            }
            ItensFolha.Valor_IR = (ItensFolha.valor_salario + ItensFolha.valor_horas_extras + ItensFolha.DSR) - (ItensFolha.Valor_desc_Faltas + ItensFolha.pagar_salario_familia + ItensFolha.Valor_Desc_INSS);
            if (ItensFolha.Valor_IR > 1903.98 && ItensFolha.Valor_IR <= 2826.65)
            {
                ItensFolha.Valor_desc_IR = (ItensFolha.Valor_IR * 0.075) - 142.80;
            }      
            else if (ItensFolha.Valor_IR >= 2826.66 && ItensFolha.Valor_IR <= 3751.05)
            {
                ItensFolha.Valor_desc_IR = (ItensFolha.Valor_IR * 0.15) - 354.80;
            }
            else if (ItensFolha.Valor_IR >= 3751.06 && ItensFolha.Valor_IR <= 4664.68)
            {
                ItensFolha.Valor_desc_IR = (ItensFolha.Valor_IR * 0.225) - 636.13;
            }
            else if (ItensFolha.Valor_IR >4664.69)
            {
                ItensFolha.Valor_desc_IR = (ItensFolha.Valor_IR * 0.275) - 869.36;
            }
            ItensFolha.valor_vale_transporte = ItensFolha.valor_salario * 0.06;
            ItensFolha.valor_fgts = ItensFolha.valor_salario * 0.08;
            ItensFolha.valor_total_proventos = ItensFolha.valor_salario + ItensFolha.valor_horas_extras + ItensFolha.DSR + ItensFolha.salario_familia;
            ItensFolha.valor_total_descontos = ItensFolha.Valor_Inss + ItensFolha.Valor_desc_IR + ItensFolha.valor_vale_transporte + ItensFolha.faltas;
            ItensFolha.valor_salario_liquido = ItensFolha.valor_total_proventos - ItensFolha.valor_total_descontos;
            MessageBox.Show(""+ ItensFolha.valor_salario_liquido);
            form_holerite_calculo calculo = new form_holerite_calculo();
            calculo.Show();
        }
    }
}
