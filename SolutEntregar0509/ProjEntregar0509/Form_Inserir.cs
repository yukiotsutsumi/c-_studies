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

namespace ProjEntregar0509
{
    public partial class Form_Inserir : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=Street-labs-PC; Initial Catalog=login_ecologize; Trusted_Connection=True");
        SqlCommand sql = new SqlCommand();
        public Form_Inserir()
        {
            InitializeComponent();
        }

        private void Form_Inserir_Load(object sender, EventArgs e)
        {
            sql.Connection = conexao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                sql.CommandText = "insert into cad_usu(nome, usu_login, senha) values ('" + txt_nome.Text + "','" + txt_login.Text + "','" + txt_senha.Text + "')";
                sql.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Registro Incluido", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_login.Clear();
                txt_nome.Clear();
                txt_senha.Clear();
                txt_login.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de inclusão" + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
