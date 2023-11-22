namespace progatividade
{
    partial class formCarrinho
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
            this.lblprodutos = new System.Windows.Forms.Label();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstprodutos = new System.Windows.Forms.ListBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprodutos
            // 
            this.lblprodutos.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodutos.Location = new System.Drawing.Point(28, 17);
            this.lblprodutos.Name = "lblprodutos";
            this.lblprodutos.Size = new System.Drawing.Size(132, 31);
            this.lblprodutos.TabIndex = 0;
            this.lblprodutos.Text = "Produtos";
            this.lblprodutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(28, 51);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(132, 21);
            this.cboProdutos.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(365, 17);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(201, 55);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstprodutos
            // 
            this.lstprodutos.FormattingEnabled = true;
            this.lstprodutos.Location = new System.Drawing.Point(34, 152);
            this.lstprodutos.Name = "lstprodutos";
            this.lstprodutos.Size = new System.Drawing.Size(532, 238);
            this.lstprodutos.TabIndex = 4;
            this.lstprodutos.SelectedIndexChanged += new System.EventHandler(this.lstprodutos_SelectedIndexChanged);
            // 
            // lblQtd
            // 
            this.lblQtd.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(199, 17);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(124, 31);
            this.lblQtd.TabIndex = 5;
            this.lblQtd.Text = "QTD";
            this.lblQtd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 454);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lstprodutos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboProdutos);
            this.Controls.Add(this.lblprodutos);
            this.Name = "formCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.formCarrinho_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprodutos;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstprodutos;
        private System.Windows.Forms.Label lblQtd;
    }
}

