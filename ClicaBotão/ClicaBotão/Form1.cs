﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClicaBotão
{
    public partial class frmClicaBotão : Form
    {
        public frmClicaBotão()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEsquerdo_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Botão Esquerdo Clicado!!";
        }

        private void btnDireito_Click(object sender, EventArgs e)
        {
            lblMensagem.Text = "Botão Direito Clicado!!";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
