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
    public class FuncionarioApplication
    {
        private readonly FuncionarioRepository FuncionarioRepository = new FuncionarioRepository();

        public FuncionarioApplication()
        {

        }

        public Funcionario ObterFuncionario(Expression<Func<Funcionario, bool>> predicado)
        {
            return FuncionarioRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Funcionario> TodosFuncionarios()
        {
            return FuncionarioRepository.BuscarTodos().ToList();
        }

        public string SalvarFuncionario(Funcionario Funcionario)
        {
            var erro = "";
            try
            {
                if (Funcionario.Pessoa == null)
                {
                    FuncionarioRepository.Adicionar(Funcionario);
                    FuncionarioRepository.Salvar();
                }
                else
                {
                    FuncionarioRepository.Editar(Funcionario);
                    FuncionarioRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarFuncionario(Funcionario Funcionario)
        {
            var erro = "";
            try
            {
                FuncionarioRepository.Editar(Funcionario);
                FuncionarioRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirFuncionario(Funcionario funcionario)
        {
            var erro = "";

            try
            {
                FuncionarioRepository.Excluir(funcionario);
                FuncionarioRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
