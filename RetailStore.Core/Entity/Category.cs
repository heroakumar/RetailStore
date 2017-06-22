using System;
using System.Collections.Generic;
namespace RetailStore.Core.Entity
{
    public class Category
    {
        public static readonly Category CLOTHINGS = new Category("Clothing");
        public static readonly Category ELECTRONICS = new Category("Electronics");
        public static readonly Category GROCERY = new Category("Grocery");
        public static readonly Category OTHER = new Category("Other");



        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
         
    }
}
