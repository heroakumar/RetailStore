using RetailStore.Core.Entity;
using System.Collections.Generic;

namespace RetailStore.Data
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product GetByID(int id);
        void Insert(Product obj);
        void Update(Product obj);
        void Delete(int id);
        void Save();
    }
}
