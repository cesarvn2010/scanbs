using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCANBs.Desktop
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void closallforms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarNovaPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroPessoa cadastroPessoa = new Forms.CadastroPessoa();

            

            cadastroPessoa.MdiParent = this;
            cadastroPessoa.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RelatorioDeVendas relatorioVendas = new Forms.RelatorioDeVendas();
            relatorioVendas.MdiParent = this;
            relatorioVendas.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroEvento cadastroEvento = new Forms.CadastroEvento();
            cadastroEvento.MdiParent = this;
            cadastroEvento.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            closallforms();
        }

        private void incluirAtraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.RelatorioDeEventos relatorioEventos = new Forms.RelatorioDeEventos();
            relatorioEventos.MdiParent = this;
            relatorioEventos.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Somos uma empresa séria. Nossos funcionários amam carros e motos esportivas.Há um funcionário nosso que gosta muito de Opala, enquanto outros não saem do Redtube. \n  \n Versão: 1.0");
        }

        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void apresentadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.VendaIngressoApresentador ingressoApresentador = new Forms.VendaIngressoApresentador();
            ingressoApresentador.MdiParent = this;
            ingressoApresentador.Show();
        }

        private void espectadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.VendaIngressoEspectador ingressoEspectador = new Forms.VendaIngressoEspectador();
            ingressoEspectador.MdiParent = this;
            ingressoEspectador.Show();
        }

        private void cadastrarTelefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telefonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroTelefone telefones = new Forms.CadastroTelefone();
            telefones.MdiParent = this;
            telefones.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        

        private void atraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroAtração cadastroAtração = new Forms.CadastroAtração();
            cadastroAtração.MdiParent = this;
            cadastroAtração.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroVeiculo veiculo = new Forms.CadastroVeiculo();
            veiculo.MdiParent = this;
            veiculo.Show();
        }

        private void organizadoresEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.CadastroAtração atracao = new Forms.CadastroAtração();
            atracao.MdiParent = this;
            atracao.Show();
        }

        private void organizadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.VincularOrganizadorEvento organizadorEvento = new Forms.VincularOrganizadorEvento();
            organizadorEvento.MdiParent = this;
            organizadorEvento.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.RelatorioDeUsuarios relatorioPessoas = new Forms.RelatorioDeUsuarios();
            relatorioPessoas.MdiParent = this;
            relatorioPessoas.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
    }
    

