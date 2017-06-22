using RetailStore.Core.Entity;
using System.Collections.Generic;

namespace RetailStore.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private MockData data = new MockData();

        public IEnumerable<User> Get()
        {
            return data.Users;
        }

        public User GetByID(int id)
        {
            return data.Users.Find(m => m.ID == id);
        }

        public List<User> GetByRole(Role role)
        {
            return data.Users.FindAll(m => m.Role == role);
        }

        public void Insert(User obj)
        {
            data.Users.Add(obj);
        }

        public void Update(User obj)
        {
            User existing = data.Users.Find(m => m.ID == obj.ID);
            existing = obj;
        }

        public void Delete(int id)
        {
            User existing = data.Users.Find(m => m.ID == id);
            data.Users.Remove(existing);
        }

        public void Save()
        {
            //nothing here
        }
    }

}
