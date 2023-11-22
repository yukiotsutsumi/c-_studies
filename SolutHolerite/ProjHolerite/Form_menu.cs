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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }

        private void Form_menu_Load(object sender, EventArgs e)
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
            toolStripStatusLabel_Data.Text = data.ToString("d/MMMM/y") + " - " + semana;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = new DateTime();
            data = DateTime.Now;
            string semana = data.Hour.ToString();
            toolStripStatusLabel_Hora.Text = data.ToString("HH:mm:ss");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sobre sobre = new Form_Sobre();
            sobre.ShowDialog();
        }

        private void gerarHoleriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Holerite holerite = new Form_Holerite();
            holerite.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Funcionario funcionario = new Form_Funcionario();
            funcionario.ShowDialog();
        }
    }
}
