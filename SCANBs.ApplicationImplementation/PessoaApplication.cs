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
    public class PessoaApplication
    {
        private readonly PessoaRepository PessoaRepository = new PessoaRepository();
        public PessoaApplication()
        {

        }

        public Pessoa ObterPessoa(Expression<Func<Pessoa, bool>> predicado)
        {
            return PessoaRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Pessoa> TodosPessoas()
        {
            return PessoaRepository.BuscarTodos().ToList();
        }

        public string SalvarPessoa(Pessoa Pessoa)
        {
            var erro = "";
            try
            {
                if (Pessoa.IdPessoa == 0)
                {
                    PessoaRepository.Adicionar(Pessoa);
                    PessoaRepository.Salvar();
                }
                else
                {
                    PessoaRepository.Editar(Pessoa);
                    PessoaRepository.Salvar();
                }
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }

        public string EditarPessoa(Pessoa pessoa)
        {
            var erro = "";
            try
            {
                PessoaRepository.Editar(pessoa);
                PessoaRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirPessoa(Pessoa pessoa)
        {
            var erro = "";

            try
            {
                PessoaRepository.Excluir(pessoa);
                PessoaRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
