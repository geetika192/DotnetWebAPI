using userManagement.Domain;
using System.Collections.Generic;
namespace userManagement.Repository
{
    //Comman to All
    public interface IRepository<T> where T:BaseEntity  //generic constraint // generic interface 
    {
         IEnumerable<T> GetAll();
         T Get(long id); 
        int Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
