namespace splashscreen
{
    partial class Form_excluir
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
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.dgusu = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.teste_cDataSet1 = new splashscreen.teste_cDataSet1();
            this.cadusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_usuTableAdapter = new splashscreen.teste_cDataSet1TableAdapters.cad_usuTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadusuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(138, 135);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(195, 20);
            this.txt_senha.TabIndex = 11;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(138, 81);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(195, 20);
            this.txt_login.TabIndex = 10;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(138, 30);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(195, 20);
            this.txt_nome.TabIndex = 9;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(35, 123);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(88, 32);
            this.lbl_senha.TabIndex = 8;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Black;
            this.lbl_Login.Location = new System.Drawing.Point(35, 70);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(86, 32);
            this.lbl_Login.TabIndex = 7;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(32, 19);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(89, 32);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome";
            // 
            // dgusu
            // 
            this.dgusu.AutoGenerateColumns = false;
            this.dgusu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgusu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.usuloginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn});
            this.dgusu.DataSource = this.cadusuBindingSource;
            this.dgusu.Location = new System.Drawing.Point(38, 170);
            this.dgusu.Name = "dgusu";
            this.dgusu.Size = new System.Drawing.Size(295, 76);
            this.dgusu.TabIndex = 12;
            this.dgusu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusu_CellClick);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Lime;
            this.btn_sair.Location = new System.Drawing.Point(199, 264);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(134, 58);
            this.btn_sair.TabIndex = 14;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Lime;
            this.btn_excluir.Location = new System.Drawing.Point(38, 264);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(131, 58);
            this.btn_excluir.TabIndex = 13;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // teste_cDataSet1
            // 
            this.teste_cDataSet1.DataSetName = "teste_cDataSet1";
            this.teste_cDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadusuBindingSource
            // 
            this.cadusuBindingSource.DataMember = "cad_usu";
            this.cadusuBindingSource.DataSource = this.teste_cDataSet1;
            // 
            // cad_usuTableAdapter
            // 
            this.cad_usuTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // usuloginDataGridViewTextBoxColumn
            // 
            this.usuloginDataGridViewTextBoxColumn.DataPropertyName = "usu_login";
            this.usuloginDataGridViewTextBoxColumn.HeaderText = "usu_login";
            this.usuloginDataGridViewTextBoxColumn.Name = "usuloginDataGridViewTextBoxColumn";
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
            this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            // 
            // Form_excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(364, 334);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.dgusu);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form_excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_excluir";
            this.Load += new System.EventHandler(this.Form_excluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadusuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dgusu;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private teste_cDataSet1 teste_cDataSet1;
        private System.Windows.Forms.BindingSource cadusuBindingSource;
        private teste_cDataSet1TableAdapters.cad_usuTableAdapter cad_usuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    }
}