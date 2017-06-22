using RetailStore.Core.Entity;
using RetailStore.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailStore.Services
{
    public class DiscountService : IDiscountService
    {

        public DiscountModel CalculateDiscount(User user, List<Product> products)
        {
            return new DiscountModel();
        }
         
    }

}
