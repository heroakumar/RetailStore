using RetailStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
