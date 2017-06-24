using RetailStore.Core;
using RetailStore.Core.Entity;
using RetailStore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailStore.Services.Discount
{
    public class DiscountService
    {
        List<IDiscountService> DiscountServices;
        public DiscountService(List<IDiscountService> discountService)
        {
            DiscountServices = discountService;
        }

        public decimal GetTotalDiscount(List<Product> product)
        {
            decimal discount = 0;
            foreach (var discountservice in DiscountServices)
            {
                discount = discount + discountservice.CalculateDiscount(product);
            }
            return discount;
        }
    }


}
