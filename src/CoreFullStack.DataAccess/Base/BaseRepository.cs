using CoreFullStack.Domain;
using CoreFullStack.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreFullStack.DataAccess.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public DomainContext Context { get; set; }

        public BaseRepository(DomainContext context)
        {
            Context = context;
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public T Get(Guid id)
        {
            return Context.Set<T>().Where(e => e.Id.Equals(id)).SingleOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentException("entity is null");

            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentException("entity is null");
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
