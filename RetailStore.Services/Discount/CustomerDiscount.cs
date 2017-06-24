using System.Collections.Generic;
using RetailStore.Core.Entity;
using System.Linq;
using RetailStore.Core;

namespace RetailStore.Services.Discount
{
    public class CustomerDiscount : IDiscountService
    {
        public decimal CalculateDiscount(List<Product> products)
        { 
            var productTotalExceptGrocery = products.Where(p => p.Category != Category.GROCERY);

            var totalPercentileDiscount = DiscountSettingHelper.LoyelityDiscount > 0 ? (DiscountSettingHelper.LoyelityDiscount / 100) * productTotalExceptGrocery.Sum(x => x.Price) : 0;
            return totalPercentileDiscount;
        }
    }
}
