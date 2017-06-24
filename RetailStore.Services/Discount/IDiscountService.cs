using RetailStore.Core.Entity;
using System.Collections.Generic;

namespace RetailStore.Services.Discount
{
    public interface IDiscountService
    {
        decimal CalculateDiscount(List<Product> products);
    }
}
