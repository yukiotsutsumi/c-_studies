namespace proj2203
{
    partial class forminho
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
            this.cboprodutos = new System.Windows.Forms.ComboBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lstsacola = new System.Windows.Forms.ListBox();
            this.btnremover = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboprodutos
            // 
            this.cboprodutos.FormattingEnabled = true;
            this.cboprodutos.Location = new System.Drawing.Point(78, 39);
            this.cboprodutos.Name = "cboprodutos";
            this.cboprodutos.Size = new System.Drawing.Size(168, 21);
            this.cboprodutos.TabIndex = 0;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(252, 39);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(61, 21);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lstsacola
            // 
            this.lstsacola.FormattingEnabled = true;
            this.lstsacola.Location = new System.Drawing.Point(78, 66);
            this.lstsacola.Name = "lstsacola";
            this.lstsacola.Size = new System.Drawing.Size(168, 277);
            this.lstsacola.TabIndex = 2;
            this.lstsacola.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(252, 323);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(61, 20);
            this.btnremover.TabIndex = 3;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(78, 350);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(168, 20);
            this.txttotal.TabIndex = 4;
            // 
            // forminho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.lstsacola);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.cboprodutos);
            this.Name = "forminho";
            this.Text = "forminho";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboprodutos;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.ListBox lstsacola;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.TextBox txttotal;
    }
}

