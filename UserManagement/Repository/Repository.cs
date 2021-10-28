using System.Collections.Generic;
using userManagement.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;
namespace userManagement.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
       AppilcationContext context;

       DbSet<T> entities;
       
       public Repository(AppilcationContext _context)
       {
           context=_context;
           entities=context.Set<T>();
       }
        void IRepository<T>.Delete(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
            context.SaveChanges();
        }

        T IRepository<T>.Get(long id)
        {
            return entities.SingleOrDefault(t=>t.Id==id);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return entities.AsEnumerable();
        }

        int IRepository<T>.Insert(T entity)
        {
           if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Add(entity);
            return context.SaveChanges();
        }

        void IRepository<T>.Remove(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Remove(entity);
        }

        void IRepository<T>.SaveChanges()
        {
           context.SaveChanges();
        }

        void IRepository<T>.Update(T entity)
        {
            if(entity==null)
            {
                throw new ArgumentNullException();
            }
            context.Update(entity);
           context.SaveChanges();
        }
    }
}