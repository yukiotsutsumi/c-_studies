namespace splashscreen
{
    partial class splash_screen
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
            this.tempo = new System.Windows.Forms.Timer(this.components);
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.pct_logo = new System.Windows.Forms.PictureBox();
            this.wow = new System.Windows.Forms.Label();
            this.dezbarradez = new System.Windows.Forms.Label();
            this.much = new System.Windows.Forms.Label();
            this.such = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // barraProgresso
            // 
            this.barraProgresso.BackColor = System.Drawing.Color.Gray;
            this.barraProgresso.Location = new System.Drawing.Point(-2, 403);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(723, 33);
            this.barraProgresso.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.barraProgresso.TabIndex = 1;
            // 
            // tempo
            // 
            this.tempo.Enabled = true;
            this.tempo.Interval = 50;
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_tempo.Location = new System.Drawing.Point(302, 439);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(100, 23);
            this.lbl_tempo.TabIndex = 2;
            // 
            // pct_logo
            // 
            this.pct_logo.Image = global::splashscreen.Properties.Resources._18361_doge_follow_your_dreams;
            this.pct_logo.InitialImage = global::splashscreen.Properties.Resources._18361_doge_follow_your_dreams;
            this.pct_logo.Location = new System.Drawing.Point(-2, 0);
            this.pct_logo.Name = "pct_logo";
            this.pct_logo.Size = new System.Drawing.Size(723, 406);
            this.pct_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_logo.TabIndex = 0;
            this.pct_logo.TabStop = false;
            this.pct_logo.Click += new System.EventHandler(this.pct_logo_Click);
            // 
            // wow
            // 
            this.wow.BackColor = System.Drawing.Color.Black;
            this.wow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wow.ForeColor = System.Drawing.Color.Yellow;
            this.wow.Location = new System.Drawing.Point(81, 122);
            this.wow.Name = "wow";
            this.wow.Size = new System.Drawing.Size(100, 23);
            this.wow.TabIndex = 3;
            this.wow.Text = "wow";
            this.wow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dezbarradez
            // 
            this.dezbarradez.BackColor = System.Drawing.Color.Black;
            this.dezbarradez.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dezbarradez.ForeColor = System.Drawing.Color.Red;
            this.dezbarradez.Location = new System.Drawing.Point(549, 341);
            this.dezbarradez.Name = "dezbarradez";
            this.dezbarradez.Size = new System.Drawing.Size(100, 23);
            this.dezbarradez.TabIndex = 4;
            this.dezbarradez.Text = "10/10";
            this.dezbarradez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // much
            // 
            this.much.BackColor = System.Drawing.Color.Black;
            this.much.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.much.ForeColor = System.Drawing.Color.Orange;
            this.much.Location = new System.Drawing.Point(12, 268);
            this.much.Name = "much";
            this.much.Size = new System.Drawing.Size(189, 29);
            this.much.TabIndex = 5;
            this.much.Text = "much beautiful";
            this.much.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // such
            // 
            this.such.BackColor = System.Drawing.Color.Black;
            this.such.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.such.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.such.Location = new System.Drawing.Point(549, 165);
            this.such.Name = "such";
            this.such.Size = new System.Drawing.Size(114, 60);
            this.such.TabIndex = 6;
            this.such.Text = "Such animation";
            this.such.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(714, 465);
            this.Controls.Add(this.such);
            this.Controls.Add(this.much);
            this.Controls.Add(this.dezbarradez);
            this.Controls.Add(this.wow);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.pct_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.splash_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pct_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pct_logo;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Timer tempo;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Label wow;
        private System.Windows.Forms.Label dezbarradez;
        private System.Windows.Forms.Label much;
        private System.Windows.Forms.Label such;
    }
}

