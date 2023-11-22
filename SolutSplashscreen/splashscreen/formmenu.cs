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
    public partial class formmenu : Form
    {
        public formmenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string semana = data.DayOfWeek.ToString();
            switch (semana)
            {
                case "Sunday":
                    {
                        semana = "Domingo";
                        break;
                    }
                case "Monday":
                    {
                        semana = "Segunda-Feira";
                        break;
                    }
                case "Tuesday":
                    {
                        semana = "Terça-Feira";
                        break;
                    }
                case "Wednesday":
                    {
                        semana = "Quarta-Feira";
                        break;
                    }
                case "Thursday":
                    {
                        semana = "Quinta-Feira";
                        break;
                    }
                case "Friday":
                    {
                        semana = "Sexta-Feira";
                        break;
                    }
                case "Saturday":
                    {
                        semana = "Sábado";
                        break;
                    }
            }
            tss_lbl_data.Text = data.ToString("d/MMMM/y") + " - " + semana;
        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string semana = data.Hour.ToString();
            tss_lbl_hora.Text = data.ToString("HH:mm:ss");
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio relatorio = new FormRelatorio();
            relatorio.ShowDialog();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIncluir incluir = new FormIncluir();
            incluir.ShowDialog();
        }

        private void mnstrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_excluir excluir = new Form_excluir();
            excluir.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_alterar alterar = new Form_alterar();
            alterar.ShowDialog();
        }
    }
}
