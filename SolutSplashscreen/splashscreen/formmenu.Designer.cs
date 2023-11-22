namespace splashscreen
{
    partial class formmenu
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
            this.mnstrip1 = new System.Windows.Forms.MenuStrip();
            this.tsm_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tss_lbl_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.st = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss_lbl_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnstrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnstrip1
            // 
            this.mnstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_sair,
            this.relatórioToolStripMenuItem,
            this.incluirToolStripMenuItem,
            this.excluirToolStripMenuItem,
            this.alterarToolStripMenuItem});
            this.mnstrip1.Location = new System.Drawing.Point(0, 0);
            this.mnstrip1.Name = "mnstrip1";
            this.mnstrip1.Size = new System.Drawing.Size(334, 24);
            this.mnstrip1.TabIndex = 0;
            this.mnstrip1.Text = "menuStrip1";
            this.mnstrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnstrip1_ItemClicked);
            // 
            // tsm_sair
            // 
            this.tsm_sair.Name = "tsm_sair";
            this.tsm_sair.Size = new System.Drawing.Size(38, 20);
            this.tsm_sair.Text = "&Sair";
            this.tsm_sair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "&Relatório";
            this.relatórioToolStripMenuItem.Click += new System.EventHandler(this.relatórioToolStripMenuItem_Click);
            // 
            // incluirToolStripMenuItem
            // 
            this.incluirToolStripMenuItem.Name = "incluirToolStripMenuItem";
            this.incluirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.incluirToolStripMenuItem.Text = "&Incluir";
            this.incluirToolStripMenuItem.Click += new System.EventHandler(this.incluirToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.excluirToolStripMenuItem.Text = "&Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.alterarToolStripMenuItem.Text = "&Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss_lbl_data,
            this.st,
            this.tss_lbl_hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tss_lbl_data
            // 
            this.tss_lbl_data.AutoSize = false;
            this.tss_lbl_data.ForeColor = System.Drawing.Color.White;
            this.tss_lbl_data.Name = "tss_lbl_data";
            this.tss_lbl_data.Size = new System.Drawing.Size(167, 17);
            // 
            // st
            // 
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(0, 17);
            this.st.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // tss_lbl_hora
            // 
            this.tss_lbl_hora.AutoSize = false;
            this.tss_lbl_hora.ForeColor = System.Drawing.Color.White;
            this.tss_lbl_hora.Name = "tss_lbl_hora";
            this.tss_lbl_hora.Size = new System.Drawing.Size(150, 17);
            this.tss_lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 282);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnstrip1);
            this.MainMenuStrip = this.mnstrip1;
            this.Name = "formmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formmenu_Load);
            this.mnstrip1.ResumeLayout(false);
            this.mnstrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnstrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_data;
        private System.Windows.Forms.ToolStripStatusLabel st;
        private System.Windows.Forms.ToolStripStatusLabel tss_lbl_hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
    }
}