namespace ProjEntregar0509
{
    partial class Formrelatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.login_ecologizeDataSet = new ProjEntregar0509.login_ecologizeDataSet();
            this.cad_usuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_usuTableAdapter = new ProjEntregar0509.login_ecologizeDataSetTableAdapters.cad_usuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.login_ecologizeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cad_usuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjEntregar0509.rel_usuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(545, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // login_ecologizeDataSet
            // 
            this.login_ecologizeDataSet.DataSetName = "login_ecologizeDataSet";
            this.login_ecologizeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cad_usuBindingSource
            // 
            this.cad_usuBindingSource.DataMember = "cad_usu";
            this.cad_usuBindingSource.DataSource = this.login_ecologizeDataSet;
            // 
            // cad_usuTableAdapter
            // 
            this.cad_usuTableAdapter.ClearBeforeFill = true;
            // 
            // Formrelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 245);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Formrelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.Formrelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_ecologizeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cad_usuBindingSource;
        private login_ecologizeDataSet login_ecologizeDataSet;
        private login_ecologizeDataSetTableAdapters.cad_usuTableAdapter cad_usuTableAdapter;
    }
}