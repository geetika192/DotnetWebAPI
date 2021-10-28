using UserManagemment2.Domain;
using System.Collections.Generic;

namespace UserManagemment2.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(long id);
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity); //delete from database
        void Remove(T entity); //local memory
        void SaveChanges(); 
    }
}