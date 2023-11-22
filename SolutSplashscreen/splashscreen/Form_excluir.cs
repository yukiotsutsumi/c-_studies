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
    public partial class Form_excluir : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=Street-labs-PC; Initial Catalog=teste_c; Trusted_Connection=True");
        SqlCommand sql = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable usuarios = new DataTable();
        string reg_sele;

        public Form_excluir()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo sair?", "Confirmar saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form_excluir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teste_cDataSet1.cad_usu' table. You can move, or remove it, as needed.
            this.cad_usuTableAdapter.Fill(this.teste_cDataSet1.cad_usu);
            carregar();
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            conexao.Open();
            string excluir = "Delete from cad_usu where id='"+reg_sele+"'";
            SqlCommand cmd = new SqlCommand(excluir, conexao);
            cmd.Connection = conexao;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Registro Excluído!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                conexao.Close();
            }
            carregar();
        }

        private void dgusu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow registro = this.dgusu.Rows[e.RowIndex];
            reg_sele = registro.Cells[0].Value.ToString();
            txt_nome.Text = registro.Cells[1].Value.ToString();
            txt_login.Text = registro.Cells[2].Value.ToString();
            txt_senha.Text = registro.Cells[3].Value.ToString();
        }
        public void carregar()
        {
            conexao.Open();
            string sql = "select * from cad_usu";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Connection = conexao;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgusu.DataSource = ds;
            dgusu.DataMember = ds.Tables[0].TableName;
            conexao.Close();
            txt_login.Clear();
            txt_nome.Clear();
            txt_senha.Clear();
        }
    }
}
