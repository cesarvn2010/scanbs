using SCANBs.Data;
using SCANBs.Data.RepositoryImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace SCANBs.ApplicationImplementation
{
    public class EventoApplication
    {
        private readonly EventoRepository EventoRepository = new EventoRepository();
        
        public EventoApplication()
        {

        }

        public Evento ObterEvento(Expression<Func<Evento, bool>>predicado)
        {
            return EventoRepository.Buscar(predicado).FirstOrDefault();
        }

        public IList<Evento> TodosEventos()
        {
            return EventoRepository.BuscarTodos().ToList();
        }

        public class FormattedDbEntityValidationException : Exception { public FormattedDbEntityValidationException(DbEntityValidationException innerException) : base(null, innerException) { } public override string Message { get { var innerException = InnerException as DbEntityValidationException; if (innerException != null) { StringBuilder sb = new StringBuilder(); sb.AppendLine(); sb.AppendLine(); foreach (var eve in innerException.EntityValidationErrors) { sb.AppendLine(string.Format("- Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().FullName, eve.Entry.State)); foreach (var ve in eve.ValidationErrors) { sb.AppendLine(string.Format("-- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"", ve.PropertyName, eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName), ve.ErrorMessage)); } } sb.AppendLine(); return sb.ToString(); } return base.Message; } } }

        public string SalvarEvento(Evento Evento)
        {
            var erro = "";
            try
            {
                if (Evento.IdEvento == 0)
                {
                    EventoRepository.Adicionar(Evento);
                    EventoRepository.Salvar();
                }
                else
                {
                    EventoRepository.Editar(Evento);
                    EventoRepository.Salvar();
                }
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
            return erro;
        }

        public string EditarEvento(Evento evento)
        {
            var erro = "";
            try
            {
                    EventoRepository.Editar(evento);
                    EventoRepository.Salvar();
            }
            catch (Exception ex)
            {
                erro = ex.Message;
            }
            return erro;

        }

        public string ExcluirEvento(Evento evento)
        {
            var erro = "";

            try
            {
                EventoRepository.Excluir(evento);
                EventoRepository.Salvar();
            }
            catch(Exception ex)
            {
                erro = ex.Message;
            }
            return erro;
        }
    }
}
