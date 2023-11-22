using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progatividade
{
    public partial class formCarrinho : Form
    {
        string[] produtos = new string[5];
        double[] preco = new double[5];
        public formCarrinho()
        {
            InitializeComponent();
        }
        private void formCarrinho_Load_1(object sender, EventArgs e)
        {
            produtos[0] = "Batata";
            produtos[1] = "Cenoura";
            produtos[2] = "Repolho";
            produtos[3] = "Rabanete";
            produtos[4] = "Alface";
            preco[0] = 3.00;
            preco[1] = 2.00;
            preco[2] = 5.50;
            preco[3] = 3.50;
            preco[4] = 1.42;
            cboProdutos.Items.Add(produtos[0]);
            cboProdutos.Items.Add(produtos[1]);
            cboProdutos.Items.Add(produtos[2]);
            cboProdutos.Items.Add(produtos[3]);
            cboProdutos.Items.Add(produtos[4]);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int indice = cboProdutos.SelectedIndex;
            string produto = cboProdutos.Text;//nome do produto selecionado
            double valor = preco[indice];//preço do produto selecionado
            double qtd = double.Parse(textBox1.Text);
            double valortotal = valor * qtd;
            string msg = produtos[indice] + "(" + preco[indice] + "x" + qtd + "=" + valortotal + ")";
            lstprodutos.Items.Add(msg);//adicionar produto selecionado na lista
        }

        private void lstprodutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
