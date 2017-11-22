using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCANBs.Data.GenericRepository
{
    public interface iGenericRepository<T> where T: class
    {
        IQueryable<T> BuscarTodos();
        IQueryable<T> Buscar(Expression<Func<T, bool>> predicado);
        void Adicionar(T entity);
        void Excluir(T entity);
        void Editar(T entity);
        void Salvar();
        void Dispose();
    }
}
