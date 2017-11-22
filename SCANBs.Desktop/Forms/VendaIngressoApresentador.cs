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
    public partial class VendaIngressoApresentador : Form
    {
        private readonly EventoApplication EventoApplication = new EventoApplication();
        private readonly IngressoApresentadorApplication IngressoApresentadorApplication = new IngressoApresentadorApplication();
        private readonly PagamentoApplication PagamentoApplication = new PagamentoApplication();
        private readonly ApresentadorApplication ApresentadorApplication = new ApresentadorApplication();
        private readonly FuncionarioApplication FuncionarioApplication = new FuncionarioApplication();
        private Pagamento pagamento;
        private IngressoApresentador ingressoApresentador;

        public VendaIngressoApresentador()
        {
            InitializeComponent();
        }

        private void IngressoApresentador_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            comboBoxEvento.DataSource = EventoApplication.TodosEventos();
            comboBoxEvento.DisplayMember = "NomeEvento";
            comboBoxEvento.ValueMember = "IdEvento";

            comboBoxApresentador.DataSource = ApresentadorApplication.TodosApresentadors();
            comboBoxApresentador.DisplayMember = "Pessoa.NomeCompleto";
            comboBoxApresentador.ValueMember = "IdPessoaApresentador";

            //erro ocasionado na linha debaixo
            comboBoxVendedor.DataSource = FuncionarioApplication.TodosFuncionarios().Where(f => f.Cargo.DescricaoCargo == "Vendedor");
            comboBoxVendedor.DisplayMember = "Funcionario.Pessoa.NomeCompleto";
            comboBoxVendedor.ValueMember = "IdPessoaFuncionario";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            short eventoBox = 0;
            short.TryParse(comboBoxEvento.SelectedValue.ToString(), out eventoBox);
            decimal valorSugestivo = 0;
            valorSugestivo = Convert.ToDecimal(EventoApplication.TodosEventos().Where(y => y.IdEvento == eventoBox).Select(y => y.ValorSugestivoApresentador).FirstOrDefault());
            valorSugestivo = Math.Round(valorSugestivo, 2);
            labelValorSugestivo.Text = valorSugestivo.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ingressoApresentador == null)
                ingressoApresentador = new IngressoApresentador();

            decimal desconto = 0;
            decimal valorSugestivo = 0;

            decimal.TryParse(textBoxDesconto.Text, out desconto);
            decimal.TryParse(labelValorSugestivo.Text, out valorSugestivo);

            ingressoApresentador.IdPessoaApresentador = (short)comboBoxApresentador.SelectedValue;
            ingressoApresentador.IdEvento = (short)comboBoxEvento.SelectedValue;
            pagamento.IdPessoaFuncionario = (short)comboBoxApresentador.SelectedValue;
            pagamento.ValorTotal = valorSugestivo - desconto;
            pagamento.IdSituacaoPagamento = (short)comboBoxSituacaoPagamento.SelectedValue;
           

            var erro = IngressoApresentadorApplication.SalvarIngressoApresentador(ingressoApresentador);
            var erro2 = PagamentoApplication.SalvarPagamento(pagamento);

            if ((String.IsNullOrEmpty(erro)) && (String.IsNullOrEmpty(erro2)))
            {
                MessageBox.Show("Venda registrada, obrigado :)");
                CarregarDados();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Houve um erro: " + erro);
            }

        }

        public void CarregarDados()
        {
          /*  dataGridViewEtapa.DataSource = EtapaApplication.TodasEtapas().Select(x => new
            {
                x.IdEtapa,
                TipoEntrega = x.TipoEntrega.Descricao,
                x.DataInicio,
                x.DataFim,
                x.NotaMinima
            }).ToList(); */
        }

        public void LimparCampos()
        {
            textBoxDesconto.Clear();
            labelValorSugestivo.Text = "0.00";
            labelValorTotal.Text = "0.00";
            comboBoxVendedor.SelectedIndex = 0;
            comboBoxEvento.SelectedIndex = 0;
            comboBoxApresentador.SelectedIndex = 0;
            pagamento = null;
            ingressoApresentador = null;
        }
    }


}
