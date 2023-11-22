using System;
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
    public partial class Formrelatorio : Form
    {
        public Formrelatorio()
        {
            InitializeComponent();
        }

        private void Formrelatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_ecologizeDataSet.cad_usu' table. You can move, or remove it, as needed.
            this.cad_usuTableAdapter.Fill(this.login_ecologizeDataSet.cad_usu);

            this.reportViewer1.RefreshReport();
        }
    }
}
