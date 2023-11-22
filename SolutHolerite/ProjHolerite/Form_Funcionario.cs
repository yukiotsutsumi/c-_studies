using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ProjHolerite
{
    public partial class Form_Funcionario : Form
    {
        SqlConnection conexao = Conexao.getConexao();
        SqlCommand sql = new SqlCommand();
        public Form_Funcionario()
        {
            InitializeComponent();
        }

        private void Form_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
        }
    }
}
