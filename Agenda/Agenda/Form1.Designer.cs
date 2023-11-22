namespace Agenda
{
    partial class FrmAgenda
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
            this.t_nome = new System.Windows.Forms.TextBox();
            this.t_endereco = new System.Windows.Forms.TextBox();
            this.t_telefone = new System.Windows.Forms.TextBox();
            this.l_nome = new System.Windows.Forms.Label();
            this.l_endereco = new System.Windows.Forms.Label();
            this.l_telefone = new System.Windows.Forms.Label();
            this.b_exibir = new System.Windows.Forms.Button();
            this.b_limpar = new System.Windows.Forms.Button();
            this.gb_exibicao = new System.Windows.Forms.GroupBox();
            this.l_nome2 = new System.Windows.Forms.Label();
            this.l_endereco2 = new System.Windows.Forms.Label();
            this.l_telefone2 = new System.Windows.Forms.Label();
            this.p_foto = new System.Windows.Forms.PictureBox();
            this.b_sair = new System.Windows.Forms.Button();
            this.gb_exibicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // t_nome
            // 
            this.t_nome.Location = new System.Drawing.Point(216, 77);
            this.t_nome.Name = "t_nome";
            this.t_nome.Size = new System.Drawing.Size(100, 20);
            this.t_nome.TabIndex = 0;
            // 
            // t_endereco
            // 
            this.t_endereco.Location = new System.Drawing.Point(216, 135);
            this.t_endereco.Name = "t_endereco";
            this.t_endereco.Size = new System.Drawing.Size(100, 20);
            this.t_endereco.TabIndex = 1;
            // 
            // t_telefone
            // 
            this.t_telefone.Location = new System.Drawing.Point(216, 184);
            this.t_telefone.Name = "t_telefone";
            this.t_telefone.Size = new System.Drawing.Size(100, 20);
            this.t_telefone.TabIndex = 2;
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nome.Location = new System.Drawing.Point(59, 77);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(124, 20);
            this.l_nome.TabIndex = 4;
            this.l_nome.Text = "Digite seu nome";
            this.l_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_endereco
            // 
            this.l_endereco.AutoSize = true;
            this.l_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_endereco.Location = new System.Drawing.Point(59, 135);
            this.l_endereco.Name = "l_endereco";
            this.l_endereco.Size = new System.Drawing.Size(151, 20);
            this.l_endereco.TabIndex = 5;
            this.l_endereco.Text = "Digite seu endereço";
            // 
            // l_telefone
            // 
            this.l_telefone.AutoSize = true;
            this.l_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_telefone.Location = new System.Drawing.Point(59, 182);
            this.l_telefone.Name = "l_telefone";
            this.l_telefone.Size = new System.Drawing.Size(142, 20);
            this.l_telefone.TabIndex = 6;
            this.l_telefone.Text = "Digite seu telefone";
            // 
            // b_exibir
            // 
            this.b_exibir.Location = new System.Drawing.Point(364, 334);
            this.b_exibir.Name = "b_exibir";
            this.b_exibir.Size = new System.Drawing.Size(75, 38);
            this.b_exibir.TabIndex = 7;
            this.b_exibir.Text = "Exibir";
            this.b_exibir.UseVisualStyleBackColor = true;
            this.b_exibir.Click += new System.EventHandler(this.b_exibir_Click);
            // 
            // b_limpar
            // 
            this.b_limpar.Location = new System.Drawing.Point(465, 287);
            this.b_limpar.Name = "b_limpar";
            this.b_limpar.Size = new System.Drawing.Size(75, 38);
            this.b_limpar.TabIndex = 8;
            this.b_limpar.Text = "Limpar";
            this.b_limpar.UseVisualStyleBackColor = true;
            this.b_limpar.Click += new System.EventHandler(this.b_limpar_Click);
            // 
            // gb_exibicao
            // 
            this.gb_exibicao.Controls.Add(this.l_telefone2);
            this.gb_exibicao.Controls.Add(this.l_endereco2);
            this.gb_exibicao.Controls.Add(this.l_nome2);
            this.gb_exibicao.Location = new System.Drawing.Point(81, 280);
            this.gb_exibicao.Name = "gb_exibicao";
            this.gb_exibicao.Size = new System.Drawing.Size(200, 118);
            this.gb_exibicao.TabIndex = 9;
            this.gb_exibicao.TabStop = false;
            this.gb_exibicao.Text = "Exibição de dados";
            // 
            // l_nome2
            // 
            this.l_nome2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_nome2.Location = new System.Drawing.Point(22, 23);
            this.l_nome2.Name = "l_nome2";
            this.l_nome2.Size = new System.Drawing.Size(162, 18);
            this.l_nome2.TabIndex = 0;
            this.l_nome2.Text = " \r\n";
            this.l_nome2.Click += new System.EventHandler(this.l_nome2_Click);
            // 
            // l_endereco2
            // 
            this.l_endereco2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_endereco2.Location = new System.Drawing.Point(22, 54);
            this.l_endereco2.Name = "l_endereco2";
            this.l_endereco2.Size = new System.Drawing.Size(162, 16);
            this.l_endereco2.TabIndex = 1;
            this.l_endereco2.Text = " ";
            // 
            // l_telefone2
            // 
            this.l_telefone2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_telefone2.Location = new System.Drawing.Point(22, 82);
            this.l_telefone2.Name = "l_telefone2";
            this.l_telefone2.Size = new System.Drawing.Size(162, 17);
            this.l_telefone2.TabIndex = 2;
            this.l_telefone2.Text = " ";
            // 
            // p_foto
            // 
            this.p_foto.Image = global::Agenda.Properties.Resources.irineu;
            this.p_foto.Location = new System.Drawing.Point(387, 77);
            this.p_foto.Name = "p_foto";
            this.p_foto.Size = new System.Drawing.Size(153, 163);
            this.p_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_foto.TabIndex = 10;
            this.p_foto.TabStop = false;
            this.p_foto.Visible = false;
            this.p_foto.Click += new System.EventHandler(this.p_foto_Click);
            // 
            // b_sair
            // 
            this.b_sair.BackgroundImage = global::Agenda.Properties.Resources.FB_IMG_14823500781894930_1_;
            this.b_sair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_sair.Location = new System.Drawing.Point(465, 334);
            this.b_sair.Name = "b_sair";
            this.b_sair.Size = new System.Drawing.Size(75, 38);
            this.b_sair.TabIndex = 3;
            this.b_sair.Text = "Sair";
            this.b_sair.UseVisualStyleBackColor = true;
            this.b_sair.Click += new System.EventHandler(this.b_sair_Click);
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(598, 435);
            this.Controls.Add(this.p_foto);
            this.Controls.Add(this.gb_exibicao);
            this.Controls.Add(this.b_limpar);
            this.Controls.Add(this.b_exibir);
            this.Controls.Add(this.l_telefone);
            this.Controls.Add(this.l_endereco);
            this.Controls.Add(this.l_nome);
            this.Controls.Add(this.b_sair);
            this.Controls.Add(this.t_telefone);
            this.Controls.Add(this.t_endereco);
            this.Controls.Add(this.t_nome);
            this.Name = "FrmAgenda";
            this.Text = " Agenda batuta";
            this.gb_exibicao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.p_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_nome;
        private System.Windows.Forms.TextBox t_endereco;
        private System.Windows.Forms.TextBox t_telefone;
        private System.Windows.Forms.Button b_sair;
        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.Label l_endereco;
        private System.Windows.Forms.Label l_telefone;
        private System.Windows.Forms.Button b_exibir;
        private System.Windows.Forms.Button b_limpar;
        private System.Windows.Forms.GroupBox gb_exibicao;
        private System.Windows.Forms.Label l_telefone2;
        private System.Windows.Forms.Label l_endereco2;
        private System.Windows.Forms.Label l_nome2;
        private System.Windows.Forms.PictureBox p_foto;
    }
}

