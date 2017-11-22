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
    public class VeiculoApplication
    {
        private readonly VeiculoRepository VeiculoRepository = new VeiculoRepository();
        public VeiculoApplication()
        {

        }

        public Veiculo ObterVeiculo(Expression<Func<Veiculo, bool>> predicado)
        {
            return VeiculoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Veiculo> TodosVeiculos()
        {
            return VeiculoRepository.BuscarTodos().ToList();
        }

        public string SalvarVeiculo(Veiculo Veiculo)
        {
            var erro = "";
            try
            {
                if (Veiculo.IdVeiculo == 0)
                {
                    VeiculoRepository.Adicionar(Veiculo);
                    VeiculoRepository.Salvar();
                }
                else
                {
                    VeiculoRepository.Editar(Veiculo);
                    VeiculoRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarVeiculo(Veiculo Veiculo)
        {
            var erro = "";
            try
            {
                VeiculoRepository.Editar(Veiculo);
                VeiculoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirVeiculo(Veiculo Veiculo)
        {
            var erro = "";

            try
            {
                VeiculoRepository.Excluir(Veiculo);
                VeiculoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
