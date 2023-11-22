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
    public partial class form_holerite_calculo : Form
    {
        public form_holerite_calculo()
        {
            InitializeComponent();
        }

        private void form_holerite_calculo_Load(object sender, EventArgs e)
        {
            try
            {
                label37.Text = ItensFolha.nome;
                label36.Text = Convert.ToString(ItensFolha.valor_salario_liquido);
                label35.Text = Convert.ToString(ItensFolha.valor_fgts);
                label34.Text = Convert.ToString(ItensFolha.valor_total_descontos);
                label33.Text = Convert.ToString(ItensFolha.valor_total_proventos);
                label24.Text = Convert.ToString(ItensFolha.valor_salario);
                label23.Text = Convert.ToString(ItensFolha.valor_horas_extras);
                label22.Text = Convert.ToString(ItensFolha.DSR);
                label21.Text = Convert.ToString(ItensFolha.salario_familia);
                label28.Text = Convert.ToString(ItensFolha.Valor_desc_Faltas);
                label27.Text = Convert.ToString(ItensFolha.Valor_Desc_INSS);
                label26.Text = Convert.ToString(ItensFolha.Valor_desc_IR);
                label25.Text = Convert.ToString(ItensFolha.valor_vale_transporte);
            }
            catch
            {
                
            }
        }
    }
}
