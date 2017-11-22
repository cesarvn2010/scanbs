using SCANBs.Data.DataContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCANBs.Data.GenericRepository
{
    public abstract class GenericRepository<T> : IDisposable, iGenericRepository<T> where T: class
    {
        SCANBsDataContext contexto = new SCANBsDataContext();

        public IQueryable<T> BuscarTodos()
        {
            IQueryable<T> query = contexto.Set<T>();
            return query;
        }

        public IQueryable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            IQueryable<T> query = contexto.Set<T>().Where(predicado);
            return query;
        }

        public void Adicionar(T entity)
        {
            contexto.Set<T>().Add(entity);
        }

        public void Excluir(T entity)
        {
            contexto.Set<T>().Remove(entity);
        }
        
        public void Editar(T entity)
        {
            contexto.Entry(entity).State = EntityState.Modified; 
        }

        public void Salvar()
        {
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
