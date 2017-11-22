using SCANBs.Data;
using SCANBs.ApplicationImplementation;
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
    public partial class CadastroEvento : Form
    {

        private readonly EventoApplication EventoApplication = new EventoApplication();
        private readonly OrganizadorApplication OrganizadorApplication = new OrganizadorApplication();
        private readonly PessoaApplication PessoaApplication = new PessoaApplication();
        private readonly OrganizadorEventoApplication OrganizadorEventoApplication = new OrganizadorEventoApplication();
        private readonly AtracaoApplication AtracaoApplication = new AtracaoApplication();
        private Atracao atracao;
        private Evento evento;
        private OrganizadorEvento organizadorEvento;
        public string load = "";

        public CadastroEvento()
        {
            InitializeComponent();
        }

        private void CadastroEvento_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            comboBoxOrganizador.DataSource = OrganizadorApplication.TodosOrganizadors();
            //NÃO CONSEGUI COLOCAR O NOME
            comboBoxOrganizador.DisplayMember = "NomeCompleto";
            comboBoxOrganizador.ValueMember = "IdPessoaOrganizador";

            dataGridViewEvento.Visible = false;
            //textBoxEvento.Visible = false;
            buttonFechaLista.Visible = false;
            //labelCargo.Visible = false;
        }

        private void buttonCadastrarEvento_Click(object sender, EventArgs e)
        {
            if ((evento == null) && (organizadorEvento == null))
                evento = new Evento();
            organizadorEvento = new OrganizadorEvento();

            if (evento.IdEvento > 0)
            {
                evento.IdEvento = evento.IdEvento;
            }
            else
            {
                evento.IdEvento = 0;
            }
            evento.NomeEvento = (textBoxNomeEvento.Text).ToString();
            evento.DataInicio = dateTimePickerDataInicio.Value;
            evento.DataFinal = dateTimePickerDataFinal.Value;
            decimal valorSugestivoApresentador = 0;
            decimal valorSugestivoEspectador = 0;
            decimal.TryParse(textBoxValorApresentador.Text, out valorSugestivoApresentador);
            decimal.TryParse(textBoxValorEspectador.Text, out valorSugestivoApresentador);
            evento.ValorSugestivoApresentador = valorSugestivoApresentador;
            evento.ValorSugestivoEspectador = valorSugestivoEspectador;

            evento.ImagemEvento = null;


            var erroEvento = EventoApplication.SalvarEvento(evento);

            if (String.IsNullOrEmpty(erroEvento))
            {
                MessageBox.Show("Evento cadastrado com sucesso!");

                organizadorEvento.IdEvento = EventoApplication.TodosEventos().Select(x => x.IdEvento).Last();

                short idPessoaOrganizador = 0;
                idPessoaOrganizador = (short)comboBoxOrganizador.SelectedValue;
                organizadorEvento.IdPessoaOrganizador = idPessoaOrganizador;
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

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar evento: " + evento);
            }
        }


        public void CarregarDados(string load)
        {

            dataGridViewEvento.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewEvento.MultiSelect = false;
            dataGridViewEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            if (load == "*")
            {

                dataGridViewEvento.DataSource = EventoApplication.TodosEventos().Select(x => new
                {
                    x.IdEvento,
                    x.NomeEvento,
                    x.DataInicio,
                    x.DataFinal,

                }).ToList();
            }/*
            else
            {
                dataGridViewPessoa.DataSource = PessoaApplication.TodosPessoas().Select(x => new
                {
                    x.IdPessoa,
                    x.NomeCompleto,
                    x.CPF,
                    x.Usuario,
                    x.Email,
                    Telefone = x.Telefone.Select(t => t.NumeroTelefone).FirstOrDefault(),
                    x.Perfil
                }).Where(x => x.NomeCompleto.Contains(load)).ToList();
            }/**/

        }

        public void LimparCampos()
        {
            textBoxNomeEvento.Clear();
            dateTimePickerDataInicio.ResetText();
            dateTimePickerDataFinal.ResetText();
            pictureBoxImagemEvento.Refresh();
            evento = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load = "*";
            CarregarDados(load);
            dataGridViewEvento.Visible = true;
            //textBoxPesquisa.Visible = true;
            buttonFechaLista.Visible = true;
        }

        private void buttonFechaLista_Click(object sender, EventArgs e)
        {
            dataGridViewEvento.Visible = false;
            //textBoxPesquisa.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewEvento.SelectedRows.Count > 0)
            {
                short idEvento = 0;
                idEvento = (short)dataGridViewEvento.CurrentRow.Cells[0].Value;
                evento = EventoApplication.ObterEvento(x => x.IdEvento == idEvento);
                short idAtracao = 0;
                
                if (MessageBox.Show("Todas as atrações antes vinculadas a este evento serão desvinculadas mas mantidas", "deseja realmente excluir o evento?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    do
                    {
                        idAtracao = AtracaoApplication.TodasAtracoes().Where(x => x.IdEvento == idEvento).Select(x => x.IdAtracao).FirstOrDefault();
                        atracao = AtracaoApplication.ObterAtracao(x => x.IdAtracao == idAtracao);
                        if (atracao != null) {
                            atracao.IdEvento = 0;
                        }
                    } while (atracao != null);

                    var erroEvento = EventoApplication.ExcluirEvento(evento);
                    if (String.IsNullOrEmpty(erroEvento))
                    {
                        MessageBox.Show("Evento excluído com sucesso!");
                        load = "*";
                        CarregarDados(load);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir evento!");
                    }
                }
            }
        }
    }
}
