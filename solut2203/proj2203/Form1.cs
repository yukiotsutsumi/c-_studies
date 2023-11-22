using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj2203
{
    public partial class forminho : Form
    {
        string[] produtos = new string[4];
        double[] preco = new double[4];
        double valortotal =0; 
        public forminho()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            produtos[0] = "batata";
            produtos[1] = "Mafagafo";
            produtos[2] = "Chuin chuin";
            produtos[3] = "Smurf";
            preco[0] = 5;
            preco[1] = 55.5;
            preco[2] = 17.83;
            preco[3] = 546.40;

            cboprodutos.Items.Add(produtos[0]);
            cboprodutos.Items.Add(produtos[1]);
            cboprodutos.Items.Add(produtos[2]);
            cboprodutos.Items.Add(produtos[3]);
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int indice = cboprodutos.SelectedIndex;//índice selecionado da cboprodutos
            string produto = cboprodutos.Text;//nome do produto selecionado
            double valor = preco[indice];//preço do produto selecionado
            lstsacola.Items.Add(produto);//adicionar produto selecionado na lista
            valortotal = valortotal + valor;
            txttotal.Text = valortotal.ToString();
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            int selecionado = lstsacola.SelectedIndex;
            // MessageBox.Show("selecionado = " + selecionado);
            if (selecionado>=0)
            {
                lstsacola.Items.RemoveAt(selecionado);
            }
        }
    }
}