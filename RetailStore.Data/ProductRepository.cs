using RetailStore.Core.Entity;
using System.Collections.Generic;

namespace RetailStore.Data
{
    public class ProductRepository : IProductRepository
    {
        private MockData data = new MockData();

        public List<Product> Get()
        {
            return data.Products;
        }

        public Product GetByID(int id)
        {
            return data.Products.Find(m => m.ID == id);
        }

        public void Insert(Product obj)
        {
            data.Products.Add(obj);
        }

        public void Update(Product obj)
        {
            Product existing = data.Products.Find(m => m.ID == obj.ID);
            existing = obj;
        }

        public void Delete(int id)
        {
            Product existing = data.Products.Find(m => m.ID == id);
            data.Products.Remove(existing);
        }

        public void Save()
        {
            //nothing here
        }
    }

}
