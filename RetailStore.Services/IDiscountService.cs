using RetailStore.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.Services
{
    public interface IDiscountService
    {
        DiscountModel CalculateDiscount(User user, List<Product> products);
    }
}
