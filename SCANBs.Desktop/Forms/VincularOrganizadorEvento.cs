using SCANBs.ApplicationImplementation;
using SCANBs.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCANBs.Desktop.Forms
{
    public partial class VincularOrganizadorEvento : Form
    {

        OrganizadorApplication OrganizadorApplication = new OrganizadorApplication();
        EventoApplication EventoApplication = new EventoApplication();
        OrganizadorEventoApplication OrganizadorEventoApplication = new OrganizadorEventoApplication();
        OrganizadorEvento organizadorEvento = null;
        

        public VincularOrganizadorEvento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            organizadorEvento = new OrganizadorEvento();

            short idPessoaOrganizador = 0;
            short idEvento = 0;
            idPessoaOrganizador = (short)comboBoxOrganizador.SelectedValue;
            idEvento = (short)comboBoxEvento.SelectedValue;
            organizadorEvento.IdPessoaOrganizador = idPessoaOrganizador;
            organizadorEvento.IdEvento = idEvento;
            organizadorEvento.DataInicioVinculo = DateTime.Now;
            var erroOrganizadorEvento = OrganizadorEventoApplication.SalvarOrganizadorEvento(organizadorEvento);
            if (String.IsNullOrEmpty(erroOrganizadorEvento))
            {
                MessageBox.Show("O organizador de nome:" + OrganizadorApplication.TodosOrganizadors().Where(x => x.Pessoa.IdPessoa == idPessoaOrganizador).Select(t => t.Pessoa.NomeCompleto).FirstOrDefault().ToString() + " foi vinculado ao evento.");
            }
            else
            {
                MessageBox.Show("Não foi possível vincular o organizador selecionado ao evento");
            }
        }

        private void VincularOrganizadorEvento_Load(object sender, EventArgs e)
        {
            comboBoxOrganizador.DataSource = OrganizadorApplication.TodosOrganizadors();
            comboBoxOrganizador.DisplayMember = "new Organizador.Pessoa().NomeCompleto";
            comboBoxOrganizador.ValueMember = "IdPessoaOrganizador";

            comboBoxEvento.DataSource = EventoApplication.TodosEventos();
            comboBoxEvento.DisplayMember = "NomeEvento";
            comboBoxEvento.ValueMember = "IdEvento";
        }
    }
}
