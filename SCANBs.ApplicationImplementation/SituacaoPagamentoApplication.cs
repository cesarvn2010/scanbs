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
    public class SituacaoPagamentoApplication
    {
        private readonly SituacaoPagamentoRepository SituacaoPagamentoRepository = new SituacaoPagamentoRepository();
        public SituacaoPagamentoApplication()
        {

        }

        public SituacaoPagamento ObterSituacaoPagamento(Expression<Func<SituacaoPagamento, bool>> predicado)
        {
            return SituacaoPagamentoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<SituacaoPagamento> TodosSituacaoPagamentos()
        {
            return SituacaoPagamentoRepository.BuscarTodos().ToList();
        }

        public string SalvarSituacaoPagamento(SituacaoPagamento SituacaoPagamento)
        {
            var erro = "";
            try
            {
                if (SituacaoPagamento.IdSituacaoPagamento == 0)
                {
                    SituacaoPagamentoRepository.Adicionar(SituacaoPagamento);
                    SituacaoPagamentoRepository.Salvar();
                }
                else
                {
                    SituacaoPagamentoRepository.Editar(SituacaoPagamento);
                    SituacaoPagamentoRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarSituacaoPagamento(SituacaoPagamento SituacaoPagamento)
        {
            var erro = "";
            try
            {
                SituacaoPagamentoRepository.Editar(SituacaoPagamento);
                SituacaoPagamentoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirSituacaoPagamento(SituacaoPagamento SituacaoPagamento)
        {
            var erro = "";

            try
            {
                SituacaoPagamentoRepository.Excluir(SituacaoPagamento);
                SituacaoPagamentoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
