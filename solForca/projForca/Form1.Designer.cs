namespace projForca
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
            this.lblllllpalavras = new System.Windows.Forms.Label();
            this.lblpalavra = new System.Windows.Forms.Label();
            this.vidas = new System.Windows.Forms.Label();
            this.lblvidas = new System.Windows.Forms.Label();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblllllpalavras
            // 
            this.lblllllpalavras.AutoSize = true;
            this.lblllllpalavras.Location = new System.Drawing.Point(25, 21);
            this.lblllllpalavras.Name = "lblllllpalavras";
            this.lblllllpalavras.Size = new System.Drawing.Size(43, 13);
            this.lblllllpalavras.TabIndex = 0;
            this.lblllllpalavras.Text = "Palavra";
            // 
            // lblpalavra
            // 
            this.lblpalavra.AutoSize = true;
            this.lblpalavra.Location = new System.Drawing.Point(104, 21);
            this.lblpalavra.Name = "lblpalavra";
            this.lblpalavra.Size = new System.Drawing.Size(49, 13);
            this.lblpalavra.TabIndex = 1;
            this.lblpalavra.Text = "######";
            // 
            // vidas
            // 
            this.vidas.AutoSize = true;
            this.vidas.Location = new System.Drawing.Point(25, 64);
            this.vidas.Name = "vidas";
            this.vidas.Size = new System.Drawing.Size(33, 13);
            this.vidas.TabIndex = 2;
            this.vidas.Text = "Vidas";
            // 
            // lblvidas
            // 
            this.lblvidas.AutoSize = true;
            this.lblvidas.Location = new System.Drawing.Point(104, 64);
            this.lblvidas.Name = "lblvidas";
            this.lblvidas.Size = new System.Drawing.Size(19, 13);
            this.lblvidas.TabIndex = 3;
            this.lblvidas.Text = "10";
            // 
            // pcbFoto
            // 
            this.pcbFoto.Image = global::projForca.Properties.Resources._10;
            this.pcbFoto.Location = new System.Drawing.Point(384, 21);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(317, 177);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 4;
            this.pcbFoto.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(28, 103);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(125, 25);
            this.btnReiniciar.TabIndex = 5;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 403);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.lblvidas);
            this.Controls.Add(this.vidas);
            this.Controls.Add(this.lblpalavra);
            this.Controls.Add(this.lblllllpalavras);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblllllpalavras;
        private System.Windows.Forms.Label lblpalavra;
        private System.Windows.Forms.Label vidas;
        private System.Windows.Forms.Label lblvidas;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

