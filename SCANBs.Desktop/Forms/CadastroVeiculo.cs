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
    public partial class CadastroVeiculo : Form
    {

        private readonly ApresentadorApplication ApresentadorApplication = new ApresentadorApplication();
        private readonly VeiculoApplication VeiculoApplication = new VeiculoApplication();
        private PessoaApplication PessoaApplication = new PessoaApplication();
        private Veiculo veiculo;

        public void CarregarDados()
        {
            dataGridViewVeiculo.DataSource = VeiculoApplication.TodosVeiculos().Select(x => new
            {
                x.IdVeiculo,
                NomeApresentador = x.Apresentador.Pessoa.NomeCompleto,
                x.Modelo,
                x.Marca,
                x.Ano,
                x.FotoVeiculo
            }).ToList();
        }

        public void LimparCampos()
        {
            textBoxMarca.Clear();
            textBoxModelo.Clear();
            textBoxMarca.Clear();

            comboBoxApresentador.SelectedIndex = 0;
            veiculo = null;
        }

        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroVeiculo_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            comboBoxApresentador.DataSource = ApresentadorApplication.TodosApresentadors();
            comboBoxApresentador.DisplayMember = "Apresentador";
            comboBoxApresentador.ValueMember = "IdPessoaApresentador";

            dataGridViewVeiculo.ColumnCount = 6;
            dataGridViewVeiculo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewVeiculo.MultiSelect = false;
            dataGridViewVeiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewVeiculo.Columns[0].HeaderText = "IdVeiculo";
            dataGridViewVeiculo.Columns[0].DataPropertyName = "IdVeiculo";
            dataGridViewVeiculo.Columns[0].Name = "IdVeiculo";
            dataGridViewVeiculo.Columns[0].Width = 100;

            dataGridViewVeiculo.Columns[1].HeaderText = "Proprietário";
            dataGridViewVeiculo.Columns[1].DataPropertyName = "NomeApresentador";
            dataGridViewVeiculo.Columns[1].Name = "NomeApresentador";
            dataGridViewVeiculo.Columns[1].Width = 150;

            dataGridViewVeiculo.Columns[2].HeaderText = "Marca";
            dataGridViewVeiculo.Columns[2].DataPropertyName = "Marca";
            dataGridViewVeiculo.Columns[2].Name = "Marca";
            dataGridViewVeiculo.Columns[2].Width = 100;

            dataGridViewVeiculo.Columns[3].HeaderText = "Modelo";
            dataGridViewVeiculo.Columns[3].DataPropertyName = "Modelo";
            dataGridViewVeiculo.Columns[3].Name = "Modelo";
            dataGridViewVeiculo.Columns[3].Width = 100;

            dataGridViewVeiculo.Columns[4].HeaderText = "Ano";
            dataGridViewVeiculo.Columns[4].DataPropertyName = "Ano";
            dataGridViewVeiculo.Columns[4].Name = "Ano";
            dataGridViewVeiculo.Columns[4].Width = 50;

            dataGridViewVeiculo.Columns[5].HeaderText = "Foto";
            dataGridViewVeiculo.Columns[5].DataPropertyName = "FotoVeiculo";
            dataGridViewVeiculo.Columns[5].Name = "FotoVeiculo";
            dataGridViewVeiculo.Columns[5].Width = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (veiculo == null)
                veiculo = new Veiculo();

            int ano = 0;

            int.TryParse(textBoxAno.Text, out ano);

            veiculo.Marca = (textBoxMarca.Text).ToString();
            veiculo.Modelo = (textBoxModelo.Text).ToString();
            veiculo.Placa = (textBoxPlaca.Text).ToString();
            veiculo.FotoVeiculo = null;
            veiculo.Ano = (short) ano;

            var erro = VeiculoApplication.SalvarVeiculo(veiculo);

            if (String.IsNullOrEmpty(erro))
            {
                MessageBox.Show("Veículo cadastrado com sucesso");
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao salvar veículo: " + erro);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculo.SelectedRows.Count > 0)
            {
                short idVeiculo = (short)dataGridViewVeiculo.CurrentRow.Cells[0].Value;
                veiculo = VeiculoApplication.ObterVeiculo(x => x.IdVeiculo == idVeiculo);

                textBoxMarca.Text = veiculo.Marca.ToString();
                textBoxAno.Text = veiculo.Ano.ToString();
                textBoxModelo.Text = veiculo.Modelo.ToString();
                comboBoxApresentador.SelectedValue = veiculo.IdPessoaApresentador;
            }
            else
            {

            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewVeiculo.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    short idVeiculo = (short)dataGridViewVeiculo.CurrentRow.Cells[0].Value;
                    veiculo = VeiculoApplication.ObterVeiculo(x => x.IdVeiculo == idVeiculo);

                    var erro = VeiculoApplication.ExcluirVeiculo(veiculo);

                    if (String.IsNullOrEmpty(erro))
                    {
                        MessageBox.Show("Veículo excluida com sucesso!");
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
