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
    public class IngressoApresentadorApplication
    {
        private readonly IngressoApresentadorRepository IngressoApresentadorRepository = new IngressoApresentadorRepository();
        public IngressoApresentadorApplication()
        {

        }

        public IngressoApresentador ObterIngressoApresentador(Expression<Func<IngressoApresentador, bool>> predicado)
        {
            return IngressoApresentadorRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<IngressoApresentador> TodosIngressoApresentadors()
        {
            return IngressoApresentadorRepository.BuscarTodos().ToList();
        }

        public string SalvarIngressoApresentador(IngressoApresentador IngressoApresentador)
        {
            var erro = "";
            try
            {
                if (IngressoApresentador.IdIngressoApresentador == 0)
                {
                    IngressoApresentadorRepository.Adicionar(IngressoApresentador);
                    IngressoApresentadorRepository.Salvar();
                }
                else
                {
                    IngressoApresentadorRepository.Editar(IngressoApresentador);
                    IngressoApresentadorRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarIngressoApresentador(IngressoApresentador IngressoApresentador)
        {
            var erro = "";
            try
            {
                IngressoApresentadorRepository.Editar(IngressoApresentador);
                IngressoApresentadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirIngressoApresentador(IngressoApresentador IngressoApresentador)
        {
            var erro = "";

            try
            {
                IngressoApresentadorRepository.Excluir(IngressoApresentador);
                IngressoApresentadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
