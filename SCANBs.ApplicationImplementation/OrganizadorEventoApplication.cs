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
    public class OrganizadorEventoApplication
    {
        private readonly OrganizadorEventoRepository OrganizadorEventoRepository = new OrganizadorEventoRepository();
        public OrganizadorEventoApplication()
        {

        }

        public OrganizadorEvento ObterOrganizadorEvento(Expression<Func<OrganizadorEvento, bool>> predicado)
        {
            return OrganizadorEventoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<OrganizadorEvento> TodosOrganizadorEventos()
        {
            return OrganizadorEventoRepository.BuscarTodos().ToList();
        }

        public string SalvarOrganizadorEvento(OrganizadorEvento OrganizadorEvento)
        {
            var erro = "";
            try
            { 
                //tem que se pensar aqui quando é edição e quando não vai ser
                //if (OrganizadorEvento.IdPessoaOrganizador == 0) 
                //{
                    OrganizadorEventoRepository.Adicionar(OrganizadorEvento);
                    OrganizadorEventoRepository.Salvar();
                //}
                /*else
                {
                    OrganizadorEventoRepository.Editar(OrganizadorEvento);
                    OrganizadorEventoRepository.Salvar();
                }*/
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarOrganizadorEvento(OrganizadorEvento OrganizadorEvento)
        {
            var erro = "";
            try
            {
                OrganizadorEventoRepository.Editar(OrganizadorEvento);
                OrganizadorEventoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirOrganizadorEvento(OrganizadorEvento OrganizadorEvento)
        {
            var erro = "";

            try
            {
                OrganizadorEventoRepository.Excluir(OrganizadorEvento);
                OrganizadorEventoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
