using RetailStore.Core.Entity;
using RetailStore.Core.Extention;
using RetailStore.Services.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore.Services.Resolver
{
    public static class DiscountServiceResolver
    { 
        public static List<IDiscountService> DiscountServices(User user)
        {
            List<IDiscountService> discountServices = new List<IDiscountService>
            {
                new VolumeDiscount()
            };

            if (user.Role == Role.EMPLOYEE)
            {
                discountServices.Add(new EmployeeDiscount());
            }
            else if (user.Role == Role.AFFILATE)
            {
                discountServices.Add(new AffilateDiscount());
            }
            else if (user.Role == Role.CUSTOMER && user.IsUserEllgibleForLoyaltyDiscount())
            {
                discountServices.Add(new CustomerDiscount());
            } 

            return discountServices;
        }
    }
}
