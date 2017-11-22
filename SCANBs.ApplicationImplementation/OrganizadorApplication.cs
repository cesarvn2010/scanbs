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
    public class OrganizadorApplication
    {
        private readonly OrganizadorRepository OrganizadorRepository = new OrganizadorRepository();
        public OrganizadorApplication()
        {

        }

        public Organizador ObterOrganizador(Expression<Func<Organizador, bool>> predicado)
        {
            return OrganizadorRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Organizador> TodosOrganizadors()
        {
            return OrganizadorRepository.BuscarTodos().ToList();
        }

        public string SalvarOrganizador(Organizador Organizador)
        {
            var erro = "";
            try
            {
                if (Organizador.IdPessoaOrganizador == 0)
                {
                    OrganizadorRepository.Adicionar(Organizador);
                    OrganizadorRepository.Salvar();
                }
                else
                {
                    OrganizadorRepository.Editar(Organizador);
                    OrganizadorRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarOrganizador(Organizador Organizador)
        {
            var erro = "";
            try
            {
                OrganizadorRepository.Editar(Organizador);
                OrganizadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirOrganizador(Organizador Organizador)
        {
            var erro = "";

            try
            {
                OrganizadorRepository.Excluir(Organizador);
                OrganizadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
