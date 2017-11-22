namespace SCANBs.Desktop
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaPessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telefonesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadoresEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.organizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espectadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espectadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem,
            this.eventosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.relatóriosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovaPessoaToolStripMenuItem,
            this.telefonesToolStripMenuItem});
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // cadastrarNovaPessoaToolStripMenuItem
            // 
            this.cadastrarNovaPessoaToolStripMenuItem.Name = "cadastrarNovaPessoaToolStripMenuItem";
            this.cadastrarNovaPessoaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cadastrarNovaPessoaToolStripMenuItem.Text = "Pessoas";
            this.cadastrarNovaPessoaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovaPessoaToolStripMenuItem_Click);
            // 
            // telefonesToolStripMenuItem
            // 
            this.telefonesToolStripMenuItem.Name = "telefonesToolStripMenuItem";
            this.telefonesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.telefonesToolStripMenuItem.Text = "Telefones";
            this.telefonesToolStripMenuItem.Click += new System.EventHandler(this.telefonesToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem
            // 
            this.eventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.organizadoresToolStripMenuItem});
            this.eventosToolStripMenuItem.Name = "eventosToolStripMenuItem";
            this.eventosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.eventosToolStripMenuItem.Text = "Eventos";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizadoresEventoToolStripMenuItem,
            this.organizadoresToolStripMenuItem1});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cadastrarToolStripMenuItem.Text = "Eventos";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // organizadoresEventoToolStripMenuItem
            // 
            this.organizadoresEventoToolStripMenuItem.Name = "organizadoresEventoToolStripMenuItem";
            this.organizadoresEventoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.organizadoresEventoToolStripMenuItem.Text = "Atrações";
            this.organizadoresEventoToolStripMenuItem.Click += new System.EventHandler(this.organizadoresEventoToolStripMenuItem_Click);
            // 
            // organizadoresToolStripMenuItem1
            // 
            this.organizadoresToolStripMenuItem1.Name = "organizadoresToolStripMenuItem1";
            this.organizadoresToolStripMenuItem1.Size = new System.Drawing.Size(233, 22);
            this.organizadoresToolStripMenuItem1.Text = "Vincular Organizador a Evento";
            this.organizadoresToolStripMenuItem1.Click += new System.EventHandler(this.organizadoresToolStripMenuItem1_Click);
            // 
            // organizadoresToolStripMenuItem
            // 
            this.organizadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apresentadoresToolStripMenuItem,
            this.espectadoresToolStripMenuItem});
            this.organizadoresToolStripMenuItem.Name = "organizadoresToolStripMenuItem";
            this.organizadoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.organizadoresToolStripMenuItem.Text = "Interessados";
            // 
            // apresentadoresToolStripMenuItem
            // 
            this.apresentadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veículosToolStripMenuItem1});
            this.apresentadoresToolStripMenuItem.Name = "apresentadoresToolStripMenuItem";
            this.apresentadoresToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.apresentadoresToolStripMenuItem.Text = "Apresentadores";
            // 
            // veículosToolStripMenuItem1
            // 
            this.veículosToolStripMenuItem1.Name = "veículosToolStripMenuItem1";
            this.veículosToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.veículosToolStripMenuItem1.Text = "Veículos";
            // 
            // espectadoresToolStripMenuItem
            // 
            this.espectadoresToolStripMenuItem.Name = "espectadoresToolStripMenuItem";
            this.espectadoresToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.espectadoresToolStripMenuItem.Text = "Espectadores";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apresentadorToolStripMenuItem,
            this.espectadorToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 20);
            this.toolStripMenuItem1.Text = "Vendas de Ingressos";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // apresentadorToolStripMenuItem
            // 
            this.apresentadorToolStripMenuItem.Name = "apresentadorToolStripMenuItem";
            this.apresentadorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.apresentadorToolStripMenuItem.Text = "Apresentador";
            this.apresentadorToolStripMenuItem.Click += new System.EventHandler(this.apresentadorToolStripMenuItem_Click);
            // 
            // espectadorToolStripMenuItem
            // 
            this.espectadorToolStripMenuItem.Name = "espectadorToolStripMenuItem";
            this.espectadorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.espectadorToolStripMenuItem.Text = "Espectador";
            this.espectadorToolStripMenuItem.Click += new System.EventHandler(this.espectadorToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendasToolStripMenuItem,
            this.eventosToolStripMenuItem1,
            this.usuáriosToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // eventosToolStripMenuItem1
            // 
            this.eventosToolStripMenuItem1.Name = "eventosToolStripMenuItem1";
            this.eventosToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.eventosToolStripMenuItem1.Text = "Eventos";
            this.eventosToolStripMenuItem1.Click += new System.EventHandler(this.eventosToolStripMenuItem1_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(945, 513);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Show Cars and Bikes";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaPessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apresentadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espectadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telefonesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizadoresEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apresentadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem espectadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

