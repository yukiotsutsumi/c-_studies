namespace ProjEntregar0509
{
    partial class Splash_Screen
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
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.lbl_tempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb1
            // 
            this.pcb1.Image = global::ProjEntregar0509.Properties.Resources.logopsd;
            this.pcb1.Location = new System.Drawing.Point(0, 0);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(604, 103);
            this.pcb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcb1.TabIndex = 0;
            this.pcb1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(0, 100);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(604, 32);
            this.barraProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgresso.TabIndex = 1;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_tempo.Location = new System.Drawing.Point(262, 135);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(97, 32);
            this.lbl_tempo.TabIndex = 2;
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(603, 166);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.pcb1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Label lbl_tempo;
    }
}

