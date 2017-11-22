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
    public class ApresentadorApplication
    {
        private readonly ApresentadorRepository ApresentadorRepository = new ApresentadorRepository();
        public ApresentadorApplication()
        {

        }

        public Apresentador ObterApresentador(Expression<Func<Apresentador, bool>> predicado)
        {
            return ApresentadorRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Apresentador> TodosApresentadors()
        {
            return ApresentadorRepository.BuscarTodos().ToList();
        }

        public string SalvarApresentador(Apresentador Apresentador)
        {
            var erro = "";
            try
            {
                if (Apresentador.IdPessoaApresentador == 0)
                {
                    ApresentadorRepository.Adicionar(Apresentador);
                    ApresentadorRepository.Salvar();
                }
                else
                {
                    ApresentadorRepository.Editar(Apresentador);
                    ApresentadorRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarApresentador(Apresentador Apresentador)
        {
            var erro = "";
            try
            {
                ApresentadorRepository.Editar(Apresentador);
                ApresentadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirApresentador(Apresentador Apresentador)
        {
            var erro = "";

            try
            {
                ApresentadorRepository.Excluir(Apresentador);
                ApresentadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
