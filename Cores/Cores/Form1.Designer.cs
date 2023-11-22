namespace Cores
{
    partial class Micalateia
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
            this.b_Verde = new System.Windows.Forms.Button();
            this.b_Azul = new System.Windows.Forms.Button();
            this.b_Vermelho = new System.Windows.Forms.Button();
            this.b_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_Verde
            // 
            this.b_Verde.Location = new System.Drawing.Point(56, 165);
            this.b_Verde.Name = "b_Verde";
            this.b_Verde.Size = new System.Drawing.Size(104, 53);
            this.b_Verde.TabIndex = 0;
            this.b_Verde.Text = "Verde";
            this.b_Verde.UseVisualStyleBackColor = true;
            this.b_Verde.Click += new System.EventHandler(this.b_Verde_Click);
            // 
            // b_Azul
            // 
            this.b_Azul.Location = new System.Drawing.Point(56, 47);
            this.b_Azul.Name = "b_Azul";
            this.b_Azul.Size = new System.Drawing.Size(104, 53);
            this.b_Azul.TabIndex = 1;
            this.b_Azul.Text = "Azul";
            this.b_Azul.UseVisualStyleBackColor = true;
            this.b_Azul.Click += new System.EventHandler(this.b_Azul_Click);
            // 
            // b_Vermelho
            // 
            this.b_Vermelho.Location = new System.Drawing.Point(56, 106);
            this.b_Vermelho.Name = "b_Vermelho";
            this.b_Vermelho.Size = new System.Drawing.Size(104, 53);
            this.b_Vermelho.TabIndex = 2;
            this.b_Vermelho.Text = "Vermelho";
            this.b_Vermelho.UseVisualStyleBackColor = true;
            this.b_Vermelho.Click += new System.EventHandler(this.b_Vermelho_Click);
            // 
            // b_sair
            // 
            this.b_sair.Location = new System.Drawing.Point(368, 256);
            this.b_sair.Name = "b_sair";
            this.b_sair.Size = new System.Drawing.Size(124, 60);
            this.b_sair.TabIndex = 3;
            this.b_sair.Text = "Sair";
            this.b_sair.UseVisualStyleBackColor = true;
            this.b_sair.Click += new System.EventHandler(this.b_sair_Click);
            // 
            // Micalateia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 342);
            this.Controls.Add(this.b_sair);
            this.Controls.Add(this.b_Vermelho);
            this.Controls.Add(this.b_Azul);
            this.Controls.Add(this.b_Verde);
            this.Name = "Micalateia";
            this.Text = "Micalatéia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Verde;
        private System.Windows.Forms.Button b_Azul;
        private System.Windows.Forms.Button b_Vermelho;
        private System.Windows.Forms.Button b_sair;
    }
}

