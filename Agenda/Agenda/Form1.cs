using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void l_nome2_Click(object sender, EventArgs e)
        {

        }

        private void b_exibir_Click(object sender, EventArgs e)
        {
            l_nome2.Text = t_nome.Text;
            l_endereco2.Text = t_endereco.Text;
            l_telefone2.Text = t_telefone.Text;
            p_foto.Visible = true;
        }

        private void b_limpar_Click(object sender, EventArgs e)
        {
            l_nome2.Text = "";
            t_nome.Text = "";
            l_endereco2.Text = "";
            t_endereco.Text = "";
            l_telefone2.Text = "";
            t_telefone.Text = "";
            p_foto.Image = null;
        }

        private void p_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
