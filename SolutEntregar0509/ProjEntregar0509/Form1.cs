﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjEntregar0509
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barraProgresso.Value < 100)
            {
                lbl_tempo.Text = barraProgresso.Value + "%";
                barraProgresso.Value = barraProgresso.Value + 5;
            }
            else
            {
                lbl_tempo.BackColor = Color.Transparent;
                timer1.Enabled = false;
                this.Visible = false;
                login login = new login();
                login.ShowDialog();
            }
        }
    }
}
