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
    public class TelefoneApplication
    {
        private readonly TelefoneRepository TelefoneRepository = new TelefoneRepository();
        public TelefoneApplication()
        {

        }

        public Telefone ObterTelefone(Expression<Func<Telefone, bool>> predicado)
        {
            return TelefoneRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Telefone> TodosTelefones()
        {
            return TelefoneRepository.BuscarTodos().ToList();
        }

        public string SalvarTelefone(Telefone Telefone)
        {
            var erro = "";
            try
            {
                if (Telefone.IdTelefone == 0)
                {
                    TelefoneRepository.Adicionar(Telefone);
                    TelefoneRepository.Salvar();
                }
                else
                {
                    TelefoneRepository.Editar(Telefone);
                    TelefoneRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarTelefone(Telefone Telefone)
        {
            var erro = "";
            try
            {
                TelefoneRepository.Editar(Telefone);
                TelefoneRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirTelefone(Telefone Telefone)
        {
            var erro = "";

            try
            {
                TelefoneRepository.Excluir(Telefone);
                TelefoneRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
