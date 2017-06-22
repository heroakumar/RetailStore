using RetailStore.Core.Entity;
using System.Collections.Generic;

namespace RetailStore.Data.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> Get();
        User GetByID(int id);
        List<User> GetByRole(Role role);
        void Insert(User obj);
        void Update(User obj);
        void Delete(int id);
        void Save();
    }
}
