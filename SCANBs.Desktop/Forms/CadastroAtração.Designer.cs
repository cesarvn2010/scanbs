namespace SCANBs.Desktop.Forms
{
    partial class CadastroAtração
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNomeAtracao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAtracao = new System.Windows.Forms.PictureBox();
            this.comboBoxEvento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewAtracao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtracao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtracao)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(45, 285);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(216, 23);
            this.buttonSalvar.TabIndex = 70;
            this.buttonSalvar.Text = "Vincular atração ao evento";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.button_Salvar);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "Selecionar Imagem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Imagem para atração:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Cadastro de Atração";
            // 
            // textBoxNomeAtracao
            // 
            this.textBoxNomeAtracao.Location = new System.Drawing.Point(183, 86);
            this.textBoxNomeAtracao.Name = "textBoxNomeAtracao";
            this.textBoxNomeAtracao.Size = new System.Drawing.Size(260, 20);
            this.textBoxNomeAtracao.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nome da atração:";
            // 
            // pictureBoxAtracao
            // 
            this.pictureBoxAtracao.Image = global::SCANBs.Desktop.Properties.Resources.show_empty;
            this.pictureBoxAtracao.Location = new System.Drawing.Point(176, 131);
            this.pictureBoxAtracao.Name = "pictureBoxAtracao";
            this.pictureBoxAtracao.Size = new System.Drawing.Size(206, 112);
            this.pictureBoxAtracao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAtracao.TabIndex = 68;
            this.pictureBoxAtracao.TabStop = false;
            // 
            // comboBoxEvento
            // 
            this.comboBoxEvento.FormattingEnabled = true;
            this.comboBoxEvento.Location = new System.Drawing.Point(579, 85);
            this.comboBoxEvento.Name = "comboBoxEvento";
            this.comboBoxEvento.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvento.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Evento vinculado:";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(307, 285);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(124, 23);
            this.buttonEditar.TabIndex = 73;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(483, 285);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(122, 23);
            this.buttonExcluir.TabIndex = 74;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewAtracao
            // 
            this.dataGridViewAtracao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAtracao.Location = new System.Drawing.Point(45, 350);
            this.dataGridViewAtracao.Name = "dataGridViewAtracao";
            this.dataGridViewAtracao.Size = new System.Drawing.Size(773, 198);
            this.dataGridViewAtracao.TabIndex = 75;
            // 
            // CadastroAtração
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(939, 571);
            this.Controls.Add(this.dataGridViewAtracao);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxEvento);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxAtracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNomeAtracao);
            this.Controls.Add(this.label1);
            this.Name = "CadastroAtração";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroApresentação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadastroApresentação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtracao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAtracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxAtracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNomeAtracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewAtracao;
    }
}