namespace splashscreen
{
    partial class FormRelatorio
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
            this.cad_usuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teste_cDataSet = new splashscreen.teste_cDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cad_usuTableAdapter = new splashscreen.teste_cDataSetTableAdapters.cad_usuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cad_usuBindingSource
            // 
            this.cad_usuBindingSource.DataMember = "cad_usu";
            this.cad_usuBindingSource.DataSource = this.teste_cDataSet;
            // 
            // teste_cDataSet
            // 
            this.teste_cDataSet.DataSetName = "teste_cDataSet";
            this.teste_cDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cad_usuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "splashscreen.rel_usuario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(627, 227);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cad_usuTableAdapter
            // 
            this.cad_usuTableAdapter.ClearBeforeFill = true;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 227);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cad_usuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cad_usuBindingSource;
        private teste_cDataSet teste_cDataSet;
        private teste_cDataSetTableAdapters.cad_usuTableAdapter cad_usuTableAdapter;
    }
}