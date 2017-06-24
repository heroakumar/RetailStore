using System.Collections.Generic;
using RetailStore.Core.Entity;
using System.Linq;
using RetailStore.Core;

namespace RetailStore.Services.Discount
{
    public class AffilateDiscount : IDiscountService
    {
        public decimal CalculateDiscount(List<Product> products)
        {
            
            var productTotalExceptGrocery = products.Where(p => p.Category != Category.GROCERY);
            decimal totalPercentileDiscount = DiscountSettingHelper.AffilateDiscount > 0 ? (DiscountSettingHelper.AffilateDiscount / 100) * productTotalExceptGrocery.Sum(x => x.Price) : 0;
            return totalPercentileDiscount;
        }
    }
}
