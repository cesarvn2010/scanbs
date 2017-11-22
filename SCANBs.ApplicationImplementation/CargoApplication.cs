using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCANBs.Data.RepositoryImplementation;
using SCANBs.Data;
using System.Linq.Expressions;

namespace SCANBs.ApplicationImplementation
{
    public class CargoApplication
    {
        private readonly CargoRepository CargoRepository = new CargoRepository();

        public CargoApplication()
        {

        }

        public Cargo ObterCargo(Expression<Func<Cargo, bool>> predicado)
        {
            return CargoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Cargo> TodosCargos()
        {
            return CargoRepository.BuscarTodos().ToList();
        }

        public string SalvarCargo(Cargo Cargo)
        {
            var erro = "";
            try
            {
                if (Cargo.IdCargo == 0)
                {
                    CargoRepository.Adicionar(Cargo);
                    CargoRepository.Salvar();
                }
                else
                {
                    CargoRepository.Editar(Cargo);
                    CargoRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarCargo(Cargo Cargo)
        {
            var erro = "";
            try
            {
                CargoRepository.Editar(Cargo);
                CargoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirCargo(Cargo Cargo)
        {
            var erro = "";

            try
            {
                CargoRepository.Excluir(Cargo);
                CargoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    
}
}
