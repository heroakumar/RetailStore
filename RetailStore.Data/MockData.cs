using RetailStore.Core.Entity;
using System; 
using System.Collections.Generic;

namespace RetailStore.Data
{
    public class MockData
    {
        public MockData()
        {
            Products = GetProducts();
            Users = GetUsers();
        }


        public List<Product> Products { get; set; }
        public List<User> Users { get; set; }

        private List<Product> GetProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Name = "Samsung Mobile",
                    Price = 10000,
                    Quantity = 1,
                    Category = new Category
                    {
                       Name=  "Electronics"
                    }
                },

                new Product
                {
                    Name = "Polo Tshirt",
                    Price = 600,
                    Quantity = 1, 
                    Category = new Category
                    {
                       Name=  "Clothing"
                    }
                },

                new Product
                {
                    Name = "Jeans",
                    Price = 2000,
                    Quantity = 1, 
                    Category = new Category
                    {
                       Name=  "Clothing"
                    }
                },
                new Product
                {
                    Name = "Rice",
                    Price = 100,
                    Quantity = 1,
                    Category = new Category
                    {
                       Name=  "Grocery"
                    }
                }
            };
            return products;
        }

        private List<User> GetUsers()
        {
            List<User> users = new List<User>
            {
                new User
                {
                    ID = 1,
                    FirstName = "Test Old Customer",
                    LastName = "Test",
                    CreateDate = new DateTime(2015, 1, 1),
                    Email = "testcustomer1@retailstore.com",
                    Role = new Role
                    {
                       Name=  "Customer"
                    }
                },

                new User
                {
                    ID = 2,
                    FirstName = "Test New Customer",
                    LastName = "Test",
                    CreateDate = new DateTime(2017, 1, 1),
                    Email = "testcustomer2@retailstore.com",
                    Role = new Role
                    {
                        Name="Customer"
                    }
                },
                new User
                {
                    ID = 3,
                    FirstName = "Test Affiliate Customer",
                    LastName = "Test",
                    CreateDate = new DateTime(2017, 1, 1),
                    Email = "testcustomer3@retailstore.com",
                    Role = new Role
                    {
                        Name="Affilate"
                    }
                },
                new User
                {
                    ID = 4,
                    FirstName = "Test Employee Customer",
                    LastName = "Test",
                    CreateDate = new DateTime(2017, 1, 1),
                    Email = "testcustomer4@retailstore.com",
                    Role = new Role
                    {
                        Name="Employee"
                    }
                },
            };
            return users;
        }
    }
}
