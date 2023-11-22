namespace splashscreen
{
    partial class Form_alterar
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
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.dgusu = new System.Windows.Forms.DataGridView();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.teste_cDataSet = new splashscreen.teste_cDataSet();
            this.testecDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cad_usuTableAdapter = new splashscreen.teste_cDataSetTableAdapters.cad_usuTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgusu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testecDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadusuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sair
            // 
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.Lime;
            this.btn_sair.Location = new System.Drawing.Point(199, 261);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(134, 58);
            this.btn_sair.TabIndex = 23;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.ForeColor = System.Drawing.Color.Lime;
            this.btn_alterar.Location = new System.Drawing.Point(38, 261);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(131, 58);
            this.btn_alterar.TabIndex = 22;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
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
            this.dgusu.Location = new System.Drawing.Point(38, 167);
            this.dgusu.Name = "dgusu";
            this.dgusu.Size = new System.Drawing.Size(295, 76);
            this.dgusu.TabIndex = 21;
            this.dgusu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusu_CellClick);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(138, 132);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(195, 20);
            this.txt_senha.TabIndex = 20;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(138, 78);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(195, 20);
            this.txt_login.TabIndex = 19;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(138, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(195, 20);
            this.txt_nome.TabIndex = 18;
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senha.ForeColor = System.Drawing.Color.Black;
            this.lbl_senha.Location = new System.Drawing.Point(35, 120);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(88, 32);
            this.lbl_senha.TabIndex = 17;
            this.lbl_senha.Text = "Senha";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Black;
            this.lbl_Login.Location = new System.Drawing.Point(35, 67);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(86, 32);
            this.lbl_Login.TabIndex = 16;
            this.lbl_Login.Text = "Login";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome.Location = new System.Drawing.Point(32, 16);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(89, 32);
            this.lbl_nome.TabIndex = 15;
            this.lbl_nome.Text = "Nome";
            // 
            // teste_cDataSet
            // 
            this.teste_cDataSet.DataSetName = "teste_cDataSet";
            this.teste_cDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testecDataSetBindingSource
            // 
            this.testecDataSetBindingSource.DataSource = this.teste_cDataSet;
            this.testecDataSetBindingSource.Position = 0;
            // 
            // cadusuBindingSource
            // 
            this.cadusuBindingSource.DataMember = "cad_usu";
            this.cadusuBindingSource.DataSource = this.testecDataSetBindingSource;
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
            // Form_alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(364, 334);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.dgusu);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Form_alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_alterar";
            this.Load += new System.EventHandler(this.Form_alterar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgusu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teste_cDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testecDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadusuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView dgusu;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.BindingSource testecDataSetBindingSource;
        private teste_cDataSet teste_cDataSet;
        private System.Windows.Forms.BindingSource cadusuBindingSource;
        private teste_cDataSetTableAdapters.cad_usuTableAdapter cad_usuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
    }
}