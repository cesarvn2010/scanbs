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
    public partial class CadastroTelefone : Form
    {

        private readonly TelefoneApplication TelefoneApplication = new TelefoneApplication();
        private readonly PessoaApplication PessoaApplication = new PessoaApplication();
        private Telefone telefone;

        public CadastroTelefone()
        {
            InitializeComponent();
        }

        public void CarregarDados()
        {
            dataGridViewTelefone.DataSource = TelefoneApplication.TodosTelefones().Select(x => new 
            {
                x.IdTelefone,
                CPF = x.Pessoa.CPF,
                x.NumeroTelefone
            }).ToList();
        }

        public void LimparCampos()
        {
            comboBoxIdPessoa.SelectedIndex = 0;
            textBoxNumeroTelefone.Clear();
            telefone = null;
        }

        private void CadastroTelefone_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            comboBoxIdPessoa.DataSource = PessoaApplication.TodosPessoas();
            comboBoxIdPessoa.DisplayMember = "CPF";
            comboBoxIdPessoa.ValueMember = "IdPessoa";

            dataGridViewTelefone.ColumnCount = 3;
            dataGridViewTelefone.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewTelefone.MultiSelect = false;
            dataGridViewTelefone.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewTelefone.Columns[0].HeaderText = "IdTelefone";
            dataGridViewTelefone.Columns[0].DataPropertyName = "IdTelefone";
            dataGridViewTelefone.Columns[0].Name = "IdTelefone";
            dataGridViewTelefone.Columns[0].Width = 100;

            dataGridViewTelefone.Columns[1].HeaderText = "CPF da pessoa";
            dataGridViewTelefone.Columns[1].DataPropertyName = "CPF";
            dataGridViewTelefone.Columns[1].Name = "CPF";
            dataGridViewTelefone.Columns[1].Width = 150;

            dataGridViewTelefone.Columns[2].HeaderText = "Número";
            dataGridViewTelefone.Columns[2].DataPropertyName = "NumeroTelefone";
            dataGridViewTelefone.Columns[2].Name = "NumeroTelefone";
            dataGridViewTelefone.Columns[2].Width = 150;

            CarregarDados();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            // tá dando erro nesta linha debaixo
            short idTelefone = (short)dataGridViewTelefone.CurrentRow.Cells[0].Value;
            telefone = TelefoneApplication.ObterTelefone(x => x.IdTelefone == idTelefone);

            textBoxNumeroTelefone.Text = telefone.NumeroTelefone.ToString();
            comboBoxIdPessoa.SelectedValue = telefone.IdPessoa;
        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewTelefone.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    short idTelefone = (short)dataGridViewTelefone.CurrentRow.Cells[0].Value;
                    telefone = TelefoneApplication.ObterTelefone(x => x.IdTelefone == idTelefone);

                    var erro = TelefoneApplication.ExcluirTelefone(telefone);

                    if (String.IsNullOrEmpty(erro))
                    {
                        MessageBox.Show("Telefone excluido com sucesso!");
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

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (telefone == null)
                telefone = new Telefone();

            int numeroTelefone = 0;

            int.TryParse(textBoxNumeroTelefone.Text, out numeroTelefone);

            telefone.IdPessoa = (short)comboBoxIdPessoa.SelectedValue;
            telefone.NumeroTelefone = numeroTelefone;

            var erro = TelefoneApplication.SalvarTelefone(telefone);

            if (String.IsNullOrEmpty(erro))
            {
                MessageBox.Show("Telefone cadastrada com sucesso");
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar telefone: " + erro);
            }
        }
    }
}
