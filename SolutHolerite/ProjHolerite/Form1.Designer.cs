namespace ProjHolerite
{
    partial class Form_Splash
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
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_rh = new System.Windows.Forms.Label();
            this.lbl_system = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(0, -1);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(437, 23);
            this.barraProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgresso.TabIndex = 1;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tempo.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.Location = new System.Drawing.Point(384, 25);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(53, 22);
            this.lbl_tempo.TabIndex = 2;
            this.lbl_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 200;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjHolerite.Properties.Resources.hand_money_il;
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_rh
            // 
            this.lbl_rh.AutoSize = true;
            this.lbl_rh.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rh.Location = new System.Drawing.Point(12, 388);
            this.lbl_rh.Name = "lbl_rh";
            this.lbl_rh.Size = new System.Drawing.Size(49, 24);
            this.lbl_rh.TabIndex = 3;
            this.lbl_rh.Text = "RH ";
            // 
            // lbl_system
            // 
            this.lbl_system.AutoSize = true;
            this.lbl_system.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_system.Location = new System.Drawing.Point(353, 388);
            this.lbl_system.Name = "lbl_system";
            this.lbl_system.Size = new System.Drawing.Size(84, 24);
            this.lbl_system.TabIndex = 4;
            this.lbl_system.Text = "System";
            // 
            // Form_Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(438, 411);
            this.Controls.Add(this.lbl_system);
            this.Controls.Add(this.lbl_rh);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holerite";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label lbl_rh;
        private System.Windows.Forms.Label lbl_system;
    }
}

