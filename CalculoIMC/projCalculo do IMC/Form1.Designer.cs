namespace projCalculo_do_IMC
{
    partial class formIMC
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pcbfoto = new System.Windows.Forms.PictureBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblclassificacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(124, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtaltura
            // 
            this.txtaltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtaltura.Location = new System.Drawing.Point(124, 99);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 1;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaltura_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPeso.Location = new System.Drawing.Point(124, 147);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 2;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(20, 53);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(98, 15);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Digite seu Nome ";
            // 
            // lblAltura
            // 
            this.lblAltura.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(20, 99);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(98, 20);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Digite sua altura";
            // 
            // lblpeso
            // 
            this.lblpeso.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(20, 149);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(98, 18);
            this.lblpeso.TabIndex = 5;
            this.lblpeso.Text = "Digite seu peso";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(23, 212);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(201, 35);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pcbfoto
            // 
            this.pcbfoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbfoto.Location = new System.Drawing.Point(251, 99);
            this.pcbfoto.Name = "pcbfoto";
            this.pcbfoto.Size = new System.Drawing.Size(263, 148);
            this.pcbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbfoto.TabIndex = 7;
            this.pcbfoto.TabStop = false;
            // 
            // lblnumero
            // 
            this.lblnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumero.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(251, 49);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(263, 23);
            this.lblnumero.TabIndex = 8;
            this.lblnumero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblnumero.Click += new System.EventHandler(this.lblnumero_Click);
            // 
            // lblclassificacao
            // 
            this.lblclassificacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblclassificacao.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclassificacao.Location = new System.Drawing.Point(251, 72);
            this.lblclassificacao.Name = "lblclassificacao";
            this.lblclassificacao.Size = new System.Drawing.Size(263, 24);
            this.lblclassificacao.TabIndex = 9;
            this.lblclassificacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 269);
            this.Controls.Add(this.lblclassificacao);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.pcbfoto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtNome);
            this.Name = "formIMC";
            this.Text = "IMC";
            this.Load += new System.EventHandler(this.formIMC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pcbfoto;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblclassificacao;
    }
}

