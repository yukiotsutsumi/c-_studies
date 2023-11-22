namespace ClicaBotão
{
    partial class frmClicaBotão
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
            this.btnEsquerdo = new System.Windows.Forms.Button();
            this.btnDireito = new System.Windows.Forms.Button();
            this.lblTítulo = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEsquerdo
            // 
            this.btnEsquerdo.BackColor = System.Drawing.Color.White;
            this.btnEsquerdo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsquerdo.Location = new System.Drawing.Point(200, 147);
            this.btnEsquerdo.Name = "btnEsquerdo";
            this.btnEsquerdo.Size = new System.Drawing.Size(217, 79);
            this.btnEsquerdo.TabIndex = 0;
            this.btnEsquerdo.Text = "Esquerdo";
            this.btnEsquerdo.UseVisualStyleBackColor = false;
            this.btnEsquerdo.Click += new System.EventHandler(this.btnEsquerdo_Click);
            // 
            // btnDireito
            // 
            this.btnDireito.BackColor = System.Drawing.Color.White;
            this.btnDireito.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDireito.Location = new System.Drawing.Point(560, 147);
            this.btnDireito.Name = "btnDireito";
            this.btnDireito.Size = new System.Drawing.Size(217, 79);
            this.btnDireito.TabIndex = 1;
            this.btnDireito.Text = "Direito";
            this.btnDireito.UseVisualStyleBackColor = false;
            this.btnDireito.Click += new System.EventHandler(this.btnDireito_Click);
            // 
            // lblTítulo
            // 
            this.lblTítulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTítulo.Font = new System.Drawing.Font("CommercialScript BT", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(200, 51);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(577, 83);
            this.lblTítulo.TabIndex = 3;
            this.lblTítulo.Text = "Clique em um dos Botões";
            this.lblTítulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMensagem
            // 
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(200, 270);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(577, 72);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(560, 374);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(217, 76);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmClicaBotão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(970, 473);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblTítulo);
            this.Controls.Add(this.btnDireito);
            this.Controls.Add(this.btnEsquerdo);
            this.Name = "frmClicaBotão";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEsquerdo;
        private System.Windows.Forms.Button btnDireito;
        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label btnSair;
    }
}

