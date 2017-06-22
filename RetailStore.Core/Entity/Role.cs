using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.Core.Entity
{
    public class Role
    {
         
        public string Name { get; set; }
        public string RoleDesc { get; set; }
        public List<User> Users { get; set; }
 
    }

}
