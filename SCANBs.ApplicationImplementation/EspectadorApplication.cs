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
    public class EspectadorApplication
    {
        private readonly EspectadorRepository EspectadorRepository = new EspectadorRepository();
        public EspectadorApplication()
        {

        }

        public Espectador ObterEspectador(Expression<Func<Espectador, bool>> predicado)
        {
            return EspectadorRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Espectador> TodosEspectadors()
        {
            return EspectadorRepository.BuscarTodos().ToList();
        }

        public string SalvarEspectador(Espectador Espectador)
        {
            var erro = "";
            try
            {
                if (Espectador.IdPessoaEspectador == 0)
                {
                    EspectadorRepository.Adicionar(Espectador);
                    EspectadorRepository.Salvar();
                }
                else
                {
                    EspectadorRepository.Editar(Espectador);
                    EspectadorRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarEspectador(Espectador Espectador)
        {
            var erro = "";
            try
            {
                EspectadorRepository.Editar(Espectador);
                EspectadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirEspectador(Espectador Espectador)
        {
            var erro = "";

            try
            {
                EspectadorRepository.Excluir(Espectador);
                EspectadorRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
