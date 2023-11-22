using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projForca
{
    public partial class Form1 : Form
    {
        string palavra = "";
        int numvidas = 10;

        public Form1()
        {
            InitializeComponent();

        }

        public void IniciarJogo()
        {
            string[] palavras = new string[5];
            palavras[0] = "batata";
            palavras[1] = "repolho";
            palavras[2] = "alho";
            palavras[3] = "Esfigmomanometro";
            palavras[4] = "avestruz";

            Random rnd = new Random();
            int sorteado = rnd.Next(5);
            palavra = palavras[sorteado];
            lblpalavra.Text = "";
            lblvidas.Text = "10";
            for (int k = 0; k < palavra.Length; k++)
            {
                lblpalavra.Text = lblpalavra.Text + "@";
            }
         }

        private void Form1_Load(object sender, EventArgs e)
        {

            int cont = 1;
            int left = 10;
            int top = 320;
            while (cont < 27)
            {
                char letra = (char)(64 + cont);
                CriarBotao("" + letra, left, top);
                cont++;
                left = left + 75;
                if ((left+75)> this.Width)
                {
                    left = 10;
                    top = top + 40;
                }
            }

            IniciarJogo();

            /* for(int i = 1; i <= 14; i = i + 1)
            {                
                string letra = ((char)(i + 64)).ToString();
                CriarBotao(letra, -60 + (75 * i), 70);

            }

            for (int i = 14; i <= 25; i = i + 1)
            {
                string letra = ((char)(i + 65)).ToString();
                CriarBotao(letra, -1035 + (75 * i), 100);

            }

            for (int i = 14; i <= 25; i = i + 1)
            {
                string letra = ((char)(i + 34)).ToString();
                CriarBotao(letra, -1035 + (75 * i), 200);

            } */



        }

        private void CriarBotao(string nome, int left, int top)
        {
            Button button1 = new System.Windows.Forms.Button();
            button1.Location = new System.Drawing.Point(left, top);
            button1.Name = nome;
            button1.Size = new System.Drawing.Size(75, 25);
            button1.TabIndex = 0;
            button1.Text = nome;
            button1.Click += jogar;
            button1.UseVisualStyleBackColor = true;
            this.Controls.Add(button1);
        }


        private void jogar(object sender, EventArgs e)
        { 
            Button btn = (Button)sender;
            string exibNova = "";
            string exibAtual = lblpalavra.Text;
            bool acho = false;
            btn.Enabled = false;
            if (numvidas < 1 || lblpalavra.Text.IndexOf('@') < 0) return;
            for(int k = 0; k< palavra.Length; k++)
            {
                string letra = palavra.Substring(k, 1).ToUpper();

                if (btn.Text == letra)
                {
                    exibNova = exibNova + letra;
                    acho = true;
                }
                else
                {
                    exibNova = exibNova + exibAtual.Substring(k, 1).ToUpper();

                }
            }
            if (numvidas == 10) pcbFoto.Image = Properties.Resources._9;
            if (numvidas == 9) pcbFoto.Image = Properties.Resources._8;
            if (numvidas == 8) pcbFoto.Image = Properties.Resources._7;
            if (numvidas == 7) pcbFoto.Image = Properties.Resources._6;
            if (numvidas == 6) pcbFoto.Image = Properties.Resources._5;
            if (numvidas == 5) pcbFoto.Image = Properties.Resources._4;
            if (numvidas == 4) pcbFoto.Image = Properties.Resources._3;
            if (numvidas == 3) pcbFoto.Image = Properties.Resources._2;
            if (numvidas == 2) pcbFoto.Image = Properties.Resources._1;
            if (numvidas == 1) pcbFoto.Image = Properties.Resources.original;
            if (!acho)
            {
                numvidas = numvidas - 1;
                lblvidas.Text = numvidas.ToString();
                if(numvidas<1)
                {
                    MessageBox.Show("Perdeu poO0OOORRrRAA!!");
                }
            }
            lblpalavra.Text = exibNova;
            if(exibNova.IndexOf('@') < 0)
            {
                MessageBox.Show("Parabéns poO0O00rRA!");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            for(int k=0; k < this.Controls.Count; k++)
            {
                if(this.Controls[k].Name.Length == 1)
                    {
                    this.Controls[k].Enabled = true;
                    Button btn = (Button)this.Controls[k];
                    }
            }
            numvidas = 10;
            pcbFoto.Image = Properties.Resources._10;
            IniciarJogo();
        }
    }
}
