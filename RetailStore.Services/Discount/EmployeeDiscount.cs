using System;
using System.Collections.Generic;
using RetailStore.Core.Entity;
using RetailStore.Core.Model;
using System.Linq;
using RetailStore.Core;

namespace RetailStore.Services.Discount
{
    public class EmployeeDiscount : IDiscountService
    {
        public decimal CalculateDiscount(List<Product> products)
        { 
            var productTotalExceptGrocery = products.Where(p => p.Category != Category.GROCERY);
            decimal totalPercentileDiscount = DiscountSettingHelper.EmployeeDiscount > 0 ? (DiscountSettingHelper.EmployeeDiscount / 100) * productTotalExceptGrocery.Sum(x => x.Price) : 0;

            return totalPercentileDiscount;
        }
    }
}
