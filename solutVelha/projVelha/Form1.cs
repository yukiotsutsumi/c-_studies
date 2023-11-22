using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projVelha
{
    public partial class formVelha : Form
    {
        string jogadorAtual = "X" ;
        public formVelha()
        {
            InitializeComponent();
        }

        private void formVelha_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            //MessageBox.Show(bt.Name);
            bt.Text = jogadorAtual;
            if (jogadorAtual == "X")
            {
                jogadorAtual = "O";
            }
            else
            {
                jogadorAtual = "X";
            }
            bt.Enabled = false;
            verificaFim();
        }
        private void verificaFim()
        {
            if(btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                MessageBox.Show(btn1.Text + " Venceu!");
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                MessageBox.Show(btn4.Text + " Venceu!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                MessageBox.Show(btn7.Text + " Venceu!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                MessageBox.Show(btn1.Text + " Venceu!");
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                MessageBox.Show(btn2.Text + " Venceu!");
                btn1.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn9.Enabled = false;
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                MessageBox.Show(btn3.Text + " Venceu!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                MessageBox.Show(btn1.Text + " Venceu!");
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                MessageBox.Show(btn3.Text + " Venceu!");
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn4.Enabled = false;
                btn6.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else if(btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" 
                && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                    MessageBox.Show("DEU VELHA CARALHOOOOOOOOO");
            }
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn1.Enabled = true;
            btn2.Text = "";
            btn2.Enabled = true;
            btn3.Text = "";
            btn3.Enabled = true;
            btn4.Text = "";
            btn4.Enabled = true;
            btn5.Text = "";
            btn5.Enabled = true;
            btn6.Text = "";
            btn6.Enabled = true;
            btn7.Text = "";
            btn7.Enabled = true;
            btn8.Text = "";
            btn8.Enabled = true;
            btn9.Text = "";
            btn9.Enabled = true;
        }
    }
}
