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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_login.Focus();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Campos em branco", "Caixa de aviso", MessageBoxButtons.OK);
                txt_login.Focus();
                return;
            }
            SqlConnection conexao = new SqlConnection("Data Source=Street-labs-PC; Initial Catalog=login_ecologize; Trusted_Connection=True");
            DataTable tabela = new DataTable();
            SqlDataAdapter da;
            Int32 linhas = 0;
            conexao.Open();
            string sql;
            sql = "SELECT * FROM cad_usu WHERE usu_login='" + txt_login.Text + "' AND senha='" + txt_senha.Text + "'";
            da = new SqlDataAdapter(sql, conexao);
            da.Fill(tabela);
            linhas = Convert.ToInt32(tabela.Rows.Count.ToString());
            if (linhas == 0)
            {
                MessageBox.Show("Login ou senha errados", "Caixa de aviso", MessageBoxButtons.OK);
                txt_login.Clear();
                txt_senha.Clear();
                txt_login.Focus();
                return;
            }
            else
            {
                form_menu menu = new form_menu();
                menu.ShowDialog();
                Close();
            }
        }
    }
}
