using System.Collections.Generic;
using System.Threading.Tasks;
using Custom_Middleware_Contacts.Models;
namespace Custom_Middleware_Contacts.Repository
{
    public interface IContactRepository
    {
        Task Add(Contacts item);
        Task<IEnumerable<Contacts>> GetAll();
        Task<Contacts> Find(string key);
        Task Remove(string Id);
        Task Update(Contacts item);

        bool CheckValidUserKey(string reqkey);
    }
}