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
    public class AtracaoApplication
    {
        private readonly AtracaoRepository AtracaoRepository = new AtracaoRepository();
        public AtracaoApplication()
        {

        }

        public Atracao ObterAtracao(Expression<Func<Atracao, bool>> predicado)
        {
            return AtracaoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Atracao> TodasAtracoes()
        {
            return AtracaoRepository.BuscarTodos().ToList();
        }

        public string SalvarAtracao(Atracao Atracao)
        {
            var erro = "";
            try
            {
                if (Atracao.IdAtracao == 0)
                {
                    AtracaoRepository.Adicionar(Atracao);
                    AtracaoRepository.Salvar();
                }
                else
                {
                    AtracaoRepository.Editar(Atracao);
                    AtracaoRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarAtracao(Atracao Atracao)
        {
            var erro = "";
            try
            {
                AtracaoRepository.Editar(Atracao);
                AtracaoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirAtracao(Atracao Atracao)
        {
            var erro = "";

            try
            {
                AtracaoRepository.Excluir(Atracao);
                AtracaoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
