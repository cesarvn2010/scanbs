namespace SCANBs.Desktop.Forms
{
    partial class VendaIngressoApresentador
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
            this.comboBoxSituacaoPagamento = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxVendedor = new System.Windows.Forms.ComboBox();
            this.comboBoxApresentador = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelValorSugestivo = new System.Windows.Forms.Label();
            this.comboBoxEvento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSituacaoPagamento
            // 
            this.comboBoxSituacaoPagamento.FormattingEnabled = true;
            this.comboBoxSituacaoPagamento.Location = new System.Drawing.Point(158, 350);
            this.comboBoxSituacaoPagamento.Name = "comboBoxSituacaoPagamento";
            this.comboBoxSituacaoPagamento.Size = new System.Drawing.Size(135, 21);
            this.comboBoxSituacaoPagamento.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Situação do pagamento:";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(180, 322);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(28, 13);
            this.labelValorTotal.TabIndex = 83;
            this.labelValorTotal.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Valor Total:";
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(158, 275);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(100, 20);
            this.textBoxDesconto.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Desconto:";
            // 
            // comboBoxVendedor
            // 
            this.comboBoxVendedor.FormattingEnabled = true;
            this.comboBoxVendedor.Location = new System.Drawing.Point(158, 150);
            this.comboBoxVendedor.Name = "comboBoxVendedor";
            this.comboBoxVendedor.Size = new System.Drawing.Size(135, 21);
            this.comboBoxVendedor.TabIndex = 79;
            // 
            // comboBoxApresentador
            // 
            this.comboBoxApresentador.FormattingEnabled = true;
            this.comboBoxApresentador.Location = new System.Drawing.Point(158, 193);
            this.comboBoxApresentador.Name = "comboBoxApresentador";
            this.comboBoxApresentador.Size = new System.Drawing.Size(135, 21);
            this.comboBoxApresentador.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "CPF do Vendedor:";
            // 
            // labelValorSugestivo
            // 
            this.labelValorSugestivo.AutoSize = true;
            this.labelValorSugestivo.Location = new System.Drawing.Point(177, 237);
            this.labelValorSugestivo.Name = "labelValorSugestivo";
            this.labelValorSugestivo.Size = new System.Drawing.Size(28, 13);
            this.labelValorSugestivo.TabIndex = 76;
            this.labelValorSugestivo.Text = "0.00";
            this.labelValorSugestivo.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxEvento
            // 
            this.comboBoxEvento.FormattingEnabled = true;
            this.comboBoxEvento.Location = new System.Drawing.Point(158, 101);
            this.comboBoxEvento.Name = "comboBoxEvento";
            this.comboBoxEvento.Size = new System.Drawing.Size(135, 21);
            this.comboBoxEvento.TabIndex = 75;
            this.comboBoxEvento.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Valor Sugestivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Vendas de Ingressos para apresentadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "CPF do Comprador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Selecione o evento:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(148, 400);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 23);
            this.btnCadastrar.TabIndex = 70;
            this.btnCadastrar.Text = "Registrar venda";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 87;
            this.button1.Text = "pesquisar cpf do cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 88;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 89;
            this.button2.Text = "pesquisar cpf do vendedor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(309, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 115);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "R$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(147, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "R$";
            // 
            // VendaIngressoApresentador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 466);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxSituacaoPagamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxVendedor);
            this.Controls.Add(this.comboBoxApresentador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelValorSugestivo);
            this.Controls.Add(this.comboBoxEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "VendaIngressoApresentador";
            this.Text = "VendasDeIngresso";
            this.Load += new System.EventHandler(this.IngressoApresentador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSituacaoPagamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxVendedor;
        private System.Windows.Forms.ComboBox comboBoxApresentador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelValorSugestivo;
        private System.Windows.Forms.ComboBox comboBoxEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
    }
}