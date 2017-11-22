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
    public class IngressoEspectadorApplication
    {
        private readonly IngressoEspectadorRepository IngressoEspectadorRepository = new IngressoEspectadorRepository();
        public IngressoEspectadorApplication()
        {

        }

        public IngressoEspectador ObterIngressoEspectador(Expression<Func<IngressoEspectador, bool>> predicado)
        {
            return IngressoEspectadorRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<IngressoEspectador> TodosIngressoEspectadors()
        {
            return IngressoEspectadorRepository.BuscarTodos().ToList();
        }

        public string SalvarIngressoEspectador(IngressoEspectador IngressoEspectador)
        {
            var erro = "";
            try
            {
                if (IngressoEspectador.IdIngressoEspectador == 0)
                {
                    IngressoEspectadorRepository.Adicionar(IngressoEspectador);
                    IngressoEspectadorRepository.Salvar();
                }
                else
                {
                    IngressoEspectadorRepository.Editar(IngressoEspectador);
                    IngressoEspectadorRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarIngressoEspectador(IngressoEspectador IngressoEspectador)
        {
            var erro = "";
            try
            {
                IngressoEspectadorRepository.Editar(IngressoEspectador);
                IngressoEspectadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirIngressoEspectador(IngressoEspectador IngressoEspectador)
        {
            var erro = "";

            try
            {
                IngressoEspectadorRepository.Excluir(IngressoEspectador);
                IngressoEspectadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
