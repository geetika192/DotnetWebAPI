using System.Collections.Generic;
using UserMngntp.Domain;
namespace UserMngntp.Repository
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<User> GetAll();
        int  Insert(T entity);
        void Delete(T entity); //Delete from Database
        void Remove(T entity);  //delete from local memory
        T GetUser(int id);
        void Update(T entity);
        void SaveChanges();
    
    }
}