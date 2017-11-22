using SCANBs.Data;
using SCANBs.Data.RepositoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCANBs.ApplicationImplementation
{
    public class PagamentoApplication
    {
        private readonly PagamentoRepository PagamentoRepository = new PagamentoRepository();
        public PagamentoApplication()
        {

        }

        public Pagamento ObterPagamento(Expression<Func<Pagamento, bool>> predicado)
        {
            return PagamentoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Pagamento> TodosPagamentos()
        {
            return PagamentoRepository.BuscarTodos().ToList();
        }

        public string SalvarPagamento(Pagamento Pagamento)
        {
            var erro = "";
            try
            {
                if (Pagamento.IdPagamento == 0)
                {
                    PagamentoRepository.Adicionar(Pagamento);
                    PagamentoRepository.Salvar();
                }
                else
                {
                    PagamentoRepository.Editar(Pagamento);
                    PagamentoRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarPagamento(Pagamento Pagamento)
        {
            var erro = "";
            try
            {
                PagamentoRepository.Editar(Pagamento);
                PagamentoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirPagamento(Pagamento Pagamento)
        {
            var erro = "";

            try
            {
                PagamentoRepository.Excluir(Pagamento);
                PagamentoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
