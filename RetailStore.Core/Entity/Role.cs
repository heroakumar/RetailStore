using System.Collections.Generic;

namespace RetailStore.Core.Entity
{
    public class Role
    {
        public static readonly Role EMPLOYEE = new Role("Employee");
        public static readonly Role AFFILATE = new Role("Affilate");
        public static readonly Role CUSTOMER = new Role("Customer");


        public Role(string name)
        {
            Name = name;
            RoleDesc = name;
        }



        public string Name { get; set; }
        public string RoleDesc { get; set; }
        public List<User> Users { get; set; }
    }
}
