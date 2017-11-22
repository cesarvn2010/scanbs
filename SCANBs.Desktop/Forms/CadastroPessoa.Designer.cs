namespace SCANBs.Desktop.Forms
{
    partial class CadastroPessoa
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeCompleto = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelConfirmaSenha = new System.Windows.Forms.Label();
            this.textBoxConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pictureBoxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewPessoa = new System.Windows.Forms.DataGridView();
            this.idPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoPessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPerfil = new System.Windows.Forms.ComboBox();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxFotoMuda = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.labelCargo = new System.Windows.Forms.Label();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.telefoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoMuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(157, 283);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            // 
            // textBoxNomeCompleto
            // 
            this.textBoxNomeCompleto.Location = new System.Drawing.Point(157, 100);
            this.textBoxNomeCompleto.Name = "textBoxNomeCompleto";
            this.textBoxNomeCompleto.Size = new System.Drawing.Size(188, 20);
            this.textBoxNomeCompleto.TabIndex = 5;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(406, 103);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(135, 20);
            this.textBoxCPF.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(350, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cadastro de Usuário";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Foto de perfil:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuário:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(157, 140);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(188, 20);
            this.textBoxUsuario.TabIndex = 13;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(352, 143);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 14;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(406, 143);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(135, 20);
            this.textBoxSenha.TabIndex = 15;
            this.textBoxSenha.UseSystemPasswordChar = true;
            this.textBoxSenha.TextChanged += new System.EventHandler(this.textBoxSenha_TextChanged);
            // 
            // labelConfirmaSenha
            // 
            this.labelConfirmaSenha.AutoSize = true;
            this.labelConfirmaSenha.Location = new System.Drawing.Point(566, 143);
            this.labelConfirmaSenha.Name = "labelConfirmaSenha";
            this.labelConfirmaSenha.Size = new System.Drawing.Size(86, 13);
            this.labelConfirmaSenha.TabIndex = 16;
            this.labelConfirmaSenha.Text = "Confirmar senha:";
            // 
            // textBoxConfirmaSenha
            // 
            this.textBoxConfirmaSenha.Location = new System.Drawing.Point(661, 140);
            this.textBoxConfirmaSenha.Name = "textBoxConfirmaSenha";
            this.textBoxConfirmaSenha.PasswordChar = '*';
            this.textBoxConfirmaSenha.Size = new System.Drawing.Size(135, 20);
            this.textBoxConfirmaSenha.TabIndex = 17;
            this.textBoxConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(157, 183);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(188, 20);
            this.textBoxEmail.TabIndex = 19;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // pictureBoxFotoPerfil
            // 
            this.pictureBoxFotoPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFotoPerfil.Image = global::SCANBs.Desktop.Properties.Resources.perfil_empty;
            this.pictureBoxFotoPerfil.Location = new System.Drawing.Point(547, 183);
            this.pictureBoxFotoPerfil.Name = "pictureBoxFotoPerfil";
            this.pictureBoxFotoPerfil.Size = new System.Drawing.Size(112, 70);
            this.pictureBoxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFotoPerfil.TabIndex = 39;
            this.pictureBoxFotoPerfil.TabStop = false;
            this.pictureBoxFotoPerfil.Click += new System.EventHandler(this.pictureBoxFotoPerfil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Escolher foto de perfil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(301, 283);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 41;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 42;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewPessoa
            // 
            this.dataGridViewPessoa.AutoGenerateColumns = false;
            this.dataGridViewPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPessoaDataGridViewTextBoxColumn,
            this.nomeCompletoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.fotoPessoaDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.perfilDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.dataGridViewPessoa.DataSource = this.pessoaBindingSource;
            this.dataGridViewPessoa.Location = new System.Drawing.Point(355, 385);
            this.dataGridViewPessoa.Name = "dataGridViewPessoa";
            this.dataGridViewPessoa.Size = new System.Drawing.Size(896, 213);
            this.dataGridViewPessoa.TabIndex = 43;
            this.dataGridViewPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoa_CellClick);
            this.dataGridViewPessoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPessoa_CellContentClick);
            // 
            // idPessoaDataGridViewTextBoxColumn
            // 
            this.idPessoaDataGridViewTextBoxColumn.DataPropertyName = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.HeaderText = "IdPessoa";
            this.idPessoaDataGridViewTextBoxColumn.Name = "idPessoaDataGridViewTextBoxColumn";
            // 
            // nomeCompletoDataGridViewTextBoxColumn
            // 
            this.nomeCompletoDataGridViewTextBoxColumn.DataPropertyName = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.HeaderText = "NomeCompleto";
            this.nomeCompletoDataGridViewTextBoxColumn.Name = "nomeCompletoDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // fotoPessoaDataGridViewTextBoxColumn
            // 
            this.fotoPessoaDataGridViewTextBoxColumn.DataPropertyName = "FotoPessoa";
            this.fotoPessoaDataGridViewTextBoxColumn.HeaderText = "FotoPessoa";
            this.fotoPessoaDataGridViewTextBoxColumn.Name = "fotoPessoaDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // perfilDataGridViewTextBoxColumn
            // 
            this.perfilDataGridViewTextBoxColumn.DataPropertyName = "Perfil";
            this.perfilDataGridViewTextBoxColumn.HeaderText = "Perfil";
            this.perfilDataGridViewTextBoxColumn.Name = "perfilDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Numero de Telefone (primeiro da lista)";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(SCANBs.Data.Pessoa);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Perfil:";
            // 
            // comboBoxPerfil
            // 
            this.comboBoxPerfil.FormattingEnabled = true;
            this.comboBoxPerfil.Items.AddRange(new object[] {
            "Funcionário",
            "Organizador",
            "Apresentador",
            "Espectador"});
            this.comboBoxPerfil.Location = new System.Drawing.Point(157, 226);
            this.comboBoxPerfil.Name = "comboBoxPerfil";
            this.comboBoxPerfil.Size = new System.Drawing.Size(135, 21);
            this.comboBoxPerfil.TabIndex = 45;
            this.comboBoxPerfil.SelectedIndexChanged += new System.EventHandler(this.comboBoxPerfil_SelectedIndexChanged);
            this.comboBoxPerfil.SelectedValueChanged += new System.EventHandler(this.comboBoxPerfil_SelectedValueChanged);
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPesquisa.Location = new System.Drawing.Point(942, 13);
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(277, 20);
            this.textBoxPesquisa.TabIndex = 48;
            this.textBoxPesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPesquisa_MouseClick);
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(69, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Listar Pessoas Cadastradas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxFotoMuda);
            this.groupBox1.Controls.Add(this.textBoxPesquisa);
            this.groupBox1.Location = new System.Drawing.Point(32, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1233, 279);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxFotoMuda
            // 
            this.pictureBoxFotoMuda.Image = global::SCANBs.Desktop.Properties.Resources.perfil_empty;
            this.pictureBoxFotoMuda.Location = new System.Drawing.Point(37, 39);
            this.pictureBoxFotoMuda.Name = "pictureBoxFotoMuda";
            this.pictureBoxFotoMuda.Size = new System.Drawing.Size(213, 213);
            this.pictureBoxFotoMuda.TabIndex = 49;
            this.pictureBoxFotoMuda.TabStop = false;
            this.pictureBoxFotoMuda.Click += new System.EventHandler(this.pictureBoxFoto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(254, 343);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 23);
            this.button4.TabIndex = 51;
            this.button4.Text = "Fechar listagem";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(352, 229);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(38, 13);
            this.labelCargo.TabIndex = 52;
            this.labelCargo.Text = "Cargo:";
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Administrador",
            "Organizador",
            "Vendedor",
            "Apresentador",
            "Espectador"});
            this.comboBoxCargo.Location = new System.Drawing.Point(406, 226);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCargo.TabIndex = 53;
            // 
            // telefoneBindingSource
            // 
            this.telefoneBindingSource.DataSource = typeof(SCANBs.Data.Telefone);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Telefone:";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(661, 103);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(135, 20);
            this.textBoxTelefone.TabIndex = 55;
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 637);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxPerfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewPessoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxFotoPerfil);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxConfirmaSenha);
            this.Controls.Add(this.labelConfirmaSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxNomeCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroPessoa";
            this.Text = "CadastroPessoa";
            this.Load += new System.EventHandler(this.CadastroPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoMuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefoneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeCompleto;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelConfirmaSenha;
        private System.Windows.Forms.TextBox textBoxConfirmaSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.PictureBox pictureBoxFotoPerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewPessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPerfil;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.BindingSource telefoneBindingSource;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoPessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.PictureBox pictureBoxFotoMuda;
    }
}