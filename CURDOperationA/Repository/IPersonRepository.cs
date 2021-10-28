using System.Threading.Tasks;
using System.Collections.Generic;
using CURDOperationA.Models;
using System;
namespace CURDOperationA.Repository
{
    public interface IPersonRepository<T>
    {
        public Task<T> Create(T _object);  
  
        public void Update(T _object);  
  
        public IEnumerable<T> GetAll();  
  
        public T GetById(int Id);  
  
        public void Delete(T _object);   
    }
}