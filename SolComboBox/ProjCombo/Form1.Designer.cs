namespace ProjCombo
{
    partial class Form1
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
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.lbligual = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboOperador
            // 
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cboOperador.Location = new System.Drawing.Point(216, 152);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(125, 21);
            this.cboOperador.TabIndex = 0;
            this.cboOperador.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(347, 153);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 1;
            this.txtn2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(110, 152);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 2;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(472, 156);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(13, 13);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "0";
            // 
            // lbligual
            // 
            this.lbligual.AutoSize = true;
            this.lbligual.Location = new System.Drawing.Point(453, 155);
            this.lbligual.Name = "lbligual";
            this.lbligual.Size = new System.Drawing.Size(13, 13);
            this.lbligual.TabIndex = 4;
            this.lbligual.Text = "=";
            this.lbligual.Click += new System.EventHandler(this.label2_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(347, 179);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(100, 28);
            this.btncalcular.TabIndex = 5;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 392);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbligual);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.cboOperador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lbligual;
        private System.Windows.Forms.Button btncalcular;
    }
}

