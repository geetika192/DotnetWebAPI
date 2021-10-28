using System.Collections.Generic;
using UserMngntp.Domain;
using UserMngntp.Repository;
using Microsoft.EntityFrameworkCore;
namespace UserMngntp.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        UserDbContext userDbContext;
        public Repository(UserDbContext _userDbContext)
        {
            userDbContext=_userDbContext;
        }
        public DbSet<T> entities{get;set;}
        void IRepository<T>.Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<User> IRepository<T>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        T IRepository<T>.GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        int IRepository<T>.Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<T>.Remove(T entity)
        {
            throw new System.NotImplementedException();
        }

        void IRepository<T>.SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        void IRepository<T>.Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}