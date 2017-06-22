using RetailStore.Core.Entity;
using RetailStore.Core.Model;
using System.Collections.Generic;

namespace RetailStore.Services
{
    public interface IDiscountService
    {
        DiscountModel CalculateDiscount(User user, List<Product> products);
    }
}
