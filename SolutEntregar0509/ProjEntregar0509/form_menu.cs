using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjEntregar0509
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void form_menu_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string semana = data.Hour.ToString();
            tss_lbl_hora.Text = data.ToString("HH:mm:ss");
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formrelatorio relatorio = new Formrelatorio();
            relatorio.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Inserir inserir = new Form_Inserir();
            inserir.ShowDialog();
        }
    }
}
