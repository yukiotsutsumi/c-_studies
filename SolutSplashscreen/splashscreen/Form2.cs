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

namespace splashscreen
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

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Campos em branco", "Caixa de aviso", MessageBoxButtons.OK);
                txt_login.Focus();
                return;
            }
            SqlConnection conexao = new SqlConnection("Data Source=Street-labs-PC; Initial Catalog=teste_c; Trusted_Connection=True");
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
                formmenu menu = new formmenu();
                menu.ShowDialog();
            }

          /*if (txt_login.Text == "fefe" && txt_senha.Text == "123")
            {
                MessageBox.Show("Você efetuou o login!");
                formmenu formmenu = new formmenu();
                this.Close();
                formmenu.Show();
            }
            else
            {
                MessageBox.Show("Senha ou login inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txt_login.Clear();
                txt_senha.Clear();
                txt_login.Focus();
                return;
            }        */
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_login.Focus();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
