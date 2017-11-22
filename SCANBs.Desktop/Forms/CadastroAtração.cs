using SCANBs.ApplicationImplementation;
using SCANBs.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SCANBs.Desktop.Forms
{
    public partial class CadastroAtração : Form
    {
        private readonly AtracaoApplication AtracaoApplication = new AtracaoApplication();
        private readonly EventoApplication EventoApplication = new EventoApplication();
        private Atracao atracao;

        public CadastroAtração()
        {
            InitializeComponent();
        }

        private void CadastroApresentação_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            comboBoxEvento.DataSource = EventoApplication.TodosEventos();
            comboBoxEvento.DisplayMember = "NomeEvento";
            comboBoxEvento.ValueMember = "IdEvento";

            dataGridViewAtracao.ColumnCount = 4;
            dataGridViewAtracao.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewAtracao.MultiSelect = false;
            dataGridViewAtracao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewAtracao.Columns[0].HeaderText = "IdAtracao";
            dataGridViewAtracao.Columns[0].DataPropertyName = "IdAtracao";
            dataGridViewAtracao.Columns[0].Name = "IdAtracao";
            dataGridViewAtracao.Columns[0].Width = 100;

            dataGridViewAtracao.Columns[1].HeaderText = "Nome da atração";
            dataGridViewAtracao.Columns[1].DataPropertyName = "NomeAtracao";
            dataGridViewAtracao.Columns[1].Name = "NomeAtracao";
            dataGridViewAtracao.Columns[1].Width = 150;

            dataGridViewAtracao.Columns[2].HeaderText = "Evento vinculado";
            dataGridViewAtracao.Columns[2].DataPropertyName = "NomeEvento";
            dataGridViewAtracao.Columns[2].Name = "NomeEvento";
            dataGridViewAtracao.Columns[2].Width = 150;

            dataGridViewAtracao.Columns[3].HeaderText = "Imagem";
            dataGridViewAtracao.Columns[3].DataPropertyName = "ImagemAtracao";
            dataGridViewAtracao.Columns[3].Name = "ImagemAtracao";
            dataGridViewAtracao.Columns[3].Width = 150;

            CarregarDados();
        }

        private void button_SalvaAtracao(object sender, EventArgs e)
        {

        }

        public void LimparCampos()
        {
            textBoxNomeAtracao.Clear();
            comboBoxEvento.SelectedIndex = 0;
            pictureBoxAtracao.Refresh();
            atracao = null;
        }

        private void button_Salvar(object sender, EventArgs e)
        {
            if (atracao == null)
                atracao = new Atracao();

            atracao.NomeAtracao = (textBoxNomeAtracao.Text).ToString();
            atracao.IdEvento = (short)comboBoxEvento.SelectedValue;
            atracao.ImagemAtracao = null;
            

            var erro = AtracaoApplication.SalvarAtracao(atracao);

            if (String.IsNullOrEmpty(erro))
            {
                MessageBox.Show("Atração cadastrada com sucesso");
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar atração: " + erro);
            }
        }

        public void CarregarDados()
        {
            dataGridViewAtracao.DataSource = AtracaoApplication.TodasAtracoes().Select(x => new
            {
                x.IdAtracao,
                x.NomeAtracao,
                NomeEvento =  x.Evento.NomeEvento,
                x.ImagemAtracao
            }).ToList();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtracao.SelectedRows.Count > 0)
            {
                short idAtracao = (short)dataGridViewAtracao.CurrentRow.Cells[0].Value;
                atracao = AtracaoApplication.ObterAtracao(x => x.IdAtracao == idAtracao);

                textBoxNomeAtracao.Text = atracao.NomeAtracao.ToString();
                comboBoxEvento.SelectedValue = atracao.IdEvento;
                //pictureBoxAtracao.
            }
            else
            {

            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtracao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int idAtracao = (int)dataGridViewAtracao.CurrentRow.Cells[0].Value;
                    atracao = AtracaoApplication.ObterAtracao(x => x.IdAtracao == idAtracao);

                    var erro = AtracaoApplication.ExcluirAtracao(atracao);

                    if (String.IsNullOrEmpty(erro))
                    {
                        MessageBox.Show("Atração excluida com sucesso!");
                        CarregarDados();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao  excluir!");
                    }


                }
            }
        }
    }
}
