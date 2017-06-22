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
            decimal discountPercentage = 0;

            //user is an employee of the store, he gets a 30% discount 

            if (user.Role == Role.EMPLOYEE)
            {
                discountPercentage = DiscountSettingHelper.EmployeeDiscount;
            }
            //user is an affiliate of the store, he gets a 10% discount 
            else if (user.Role == Role.AFFILATE)
            {
                discountPercentage = DiscountSettingHelper.AffilateDiscount;
            }
            //user has been a customer for over 2 years, he gets a 5 % discount
            else if (user.Role == Role.CUSTOMER && IsUserEllgibleForLoyaltyDiscount(user))
            {
                discountPercentage = DiscountSettingHelper.LoyelityDiscount;
            }

            //Total Percentage discount
            var productTotalExceptGrocery = products.Where(p => p.Category == Category.GROCERY);
            decimal totalPercentileDiscount = discountPercentage > 0 ? (discountPercentage / 100) * productTotalExceptGrocery.Sum(x => x.Price) : 0;


            //For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45 as a discount). 
            int numberOfHundredMultiply = (int)(products.Sum(x => x.Price) / DiscountSettingHelper.DiscountOnSaleVolume);
            decimal discountOnEachHundred = numberOfHundredMultiply * DiscountSettingHelper.SaleVolumeDiscount;

            return new DiscountModel
            {
                PercentileDiscount = totalPercentileDiscount,
                TotalAmountDiscount = discountOnEachHundred
            };

        }

        public static bool IsUserEllgibleForLoyaltyDiscount(User user)
        {
            return (DateTime.Now.Year-user.CreateDate.Year) >= DiscountSettingHelper.LoyaltyEligibilityYear;
        }
    }


}
