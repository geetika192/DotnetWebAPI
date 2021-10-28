using UserManagemment2.Domain;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace UserManagemment2.Repository //Data layer
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        ApplicationContext context;
        DbSet<T> entities;
        public Repository(ApplicationContext _context)
        {
            context=_context;            //DbContext--.update , insert , delete
            entities=context.Set<T>();  //DbSet-->lambda expression and linq query   ans set<>-->
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