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
    public partial class Form_login : Form
    {
        SqlConnection conexao = Conexao.getConexao();
        DataTable tabela = new DataTable();
        SqlDataAdapter da;
        Int32 linhas = 0;
        public Form_login()
        {
            InitializeComponent();
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            txt_login.Focus();
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
            /*if (txt_login.Text == "fefe" && txt_senha.Text == "123")
            {
                MessageBox.Show("Você efetuou o login!");
                Form_menu menu = new Form_menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou login inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txt_login.Clear();
                txt_senha.Clear();
                txt_login.Focus();
                return;
            }*/

                if (txt_login.Text == "" || txt_senha.Text == "")
                {
                    MessageBox.Show("Campos em branco", "Caixa de aviso", MessageBoxButtons.OK);
                    txt_login.Focus();
                    return;
                }
                conexao.Open();
                string sql;
                sql = "SELECT * FROM login_FelipeTsutsumi09 WHERE loginu='" + txt_login.Text + "' AND senha='" + txt_senha.Text + "'";
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
                MessageBox.Show("Você efetuou o login!");
                Form_menu menu = new Form_menu();
                    menu.ShowDialog();
                }
        }
        public void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_entrar_Click();
            }
        }

        private void btn_entrar_Click()
        {
            /*if (txt_login.Text == "fefe" && txt_senha.Text == "123")
            {
                MessageBox.Show("Você efetuou o login!");
                Form_menu menu = new Form_menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha ou login inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txt_login.Clear();
                txt_senha.Clear();
                txt_login.Focus();
                return;
            }*/
            if (txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Campos em branco", "Caixa de aviso", MessageBoxButtons.OK);
                txt_login.Focus();
                return;
            }
            conexao.Open();
            string sql;
            sql = "SELECT * FROM login_FelipeTsutsumi09 WHERE loginu='" + txt_login.Text + "' AND senha='" + txt_senha.Text + "'";
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
                MessageBox.Show("Você efetuou o login!");
                Form_menu menu = new Form_menu();
                menu.ShowDialog();
            }
        }
    }
}

