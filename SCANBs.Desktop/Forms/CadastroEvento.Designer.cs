namespace SCANBs.Desktop.Forms
{
    partial class CadastroEvento
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeEvento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCadastrarEvento = new System.Windows.Forms.Button();
            this.pictureBoxImagemEvento = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValorApresentador = new System.Windows.Forms.TextBox();
            this.textBoxValorEspectador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewEvento = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxOrganizador = new System.Windows.Forms.ComboBox();
            this.organizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonFechaLista = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(465, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Selecionar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Imagem promocional do evento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cadastro de Evento";
            // 
            // textBoxNomeEvento
            // 
            this.textBoxNomeEvento.Location = new System.Drawing.Point(223, 118);
            this.textBoxNomeEvento.MaxLength = 30;
            this.textBoxNomeEvento.Name = "textBoxNomeEvento";
            this.textBoxNomeEvento.Size = new System.Drawing.Size(200, 20);
            this.textBoxNomeEvento.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Quando termina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Quando começa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nome do Evento:";
            // 
            // buttonCadastrarEvento
            // 
            this.buttonCadastrarEvento.Location = new System.Drawing.Point(93, 406);
            this.buttonCadastrarEvento.Name = "buttonCadastrarEvento";
            this.buttonCadastrarEvento.Size = new System.Drawing.Size(129, 23);
            this.buttonCadastrarEvento.TabIndex = 59;
            this.buttonCadastrarEvento.Text = "Salvar";
            this.buttonCadastrarEvento.UseVisualStyleBackColor = true;
            this.buttonCadastrarEvento.Click += new System.EventHandler(this.buttonCadastrarEvento_Click);
            // 
            // pictureBoxImagemEvento
            // 
            this.pictureBoxImagemEvento.Image = global::SCANBs.Desktop.Properties.Resources.evento_empty;
            this.pictureBoxImagemEvento.Location = new System.Drawing.Point(223, 239);
            this.pictureBoxImagemEvento.Name = "pictureBoxImagemEvento";
            this.pictureBoxImagemEvento.Size = new System.Drawing.Size(206, 148);
            this.pictureBoxImagemEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemEvento.TabIndex = 57;
            this.pictureBoxImagemEvento.TabStop = false;
            // 
            // dateTimePickerDataInicio
            // 
            this.dateTimePickerDataInicio.Location = new System.Drawing.Point(223, 156);
            this.dateTimePickerDataInicio.Name = "dateTimePickerDataInicio";
            this.dateTimePickerDataInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataInicio.TabIndex = 60;
            // 
            // dateTimePickerDataFinal
            // 
            this.dateTimePickerDataFinal.Location = new System.Drawing.Point(223, 192);
            this.dateTimePickerDataFinal.Name = "dateTimePickerDataFinal";
            this.dateTimePickerDataFinal.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataFinal.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Valor sugestivo para ingresso do apresentador: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Valor sugestivo para ingresso do espectador: ";
            // 
            // textBoxValorApresentador
            // 
            this.textBoxValorApresentador.Location = new System.Drawing.Point(728, 115);
            this.textBoxValorApresentador.MaxLength = 30;
            this.textBoxValorApresentador.Name = "textBoxValorApresentador";
            this.textBoxValorApresentador.Size = new System.Drawing.Size(84, 20);
            this.textBoxValorApresentador.TabIndex = 64;
            // 
            // textBoxValorEspectador
            // 
            this.textBoxValorEspectador.Location = new System.Drawing.Point(728, 156);
            this.textBoxValorEspectador.MaxLength = 30;
            this.textBoxValorEspectador.Name = "textBoxValorEspectador";
            this.textBoxValorEspectador.Size = new System.Drawing.Size(84, 20);
            this.textBoxValorEspectador.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "R$";
            // 
            // dataGridViewEvento
            // 
            this.dataGridViewEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvento.Location = new System.Drawing.Point(62, 479);
            this.dataGridViewEvento.Name = "dataGridViewEvento";
            this.dataGridViewEvento.Size = new System.Drawing.Size(819, 245);
            this.dataGridViewEvento.TabIndex = 68;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Se preferir já informar um organizador deste evento:";
            // 
            // comboBoxOrganizador
            // 
            this.comboBoxOrganizador.DisplayMember = "IdPessoa";
            this.comboBoxOrganizador.FormattingEnabled = true;
            this.comboBoxOrganizador.Location = new System.Drawing.Point(715, 195);
            this.comboBoxOrganizador.Name = "comboBoxOrganizador";
            this.comboBoxOrganizador.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOrganizador.TabIndex = 70;
            this.comboBoxOrganizador.ValueMember = "IdPessoa";
            // 
            // organizadorBindingSource
            // 
            this.organizadorBindingSource.DataSource = typeof(SCANBs.Data.Organizador);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(502, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 12);
            this.label11.TabIndex = 71;
            this.label11.Text = "Você pode estar informando mais organizadores em: Eventos/Organizadores";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 72;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(450, 406);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 73;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 23);
            this.button4.TabIndex = 74;
            this.button4.Text = "Listar Eventos já cadastrados";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonFechaLista
            // 
            this.buttonFechaLista.Location = new System.Drawing.Point(258, 450);
            this.buttonFechaLista.Name = "buttonFechaLista";
            this.buttonFechaLista.Size = new System.Drawing.Size(171, 23);
            this.buttonFechaLista.TabIndex = 75;
            this.buttonFechaLista.Text = "Fechar lista";
            this.buttonFechaLista.UseVisualStyleBackColor = true;
            this.buttonFechaLista.Click += new System.EventHandler(this.buttonFechaLista_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(33, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 275);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(SCANBs.Data.Pessoa);
            // 
            // CadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(966, 733);
            this.Controls.Add(this.buttonFechaLista);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxOrganizador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewEvento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxValorEspectador);
            this.Controls.Add(this.textBoxValorApresentador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerDataFinal);
            this.Controls.Add(this.dateTimePickerDataInicio);
            this.Controls.Add(this.buttonCadastrarEvento);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxImagemEvento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeEvento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "CadastroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CadastroEvento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxImagemEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadastrarEvento;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValorApresentador;
        private System.Windows.Forms.TextBox textBoxValorEspectador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewEvento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxOrganizador;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonFechaLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource organizadorBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
    }
}