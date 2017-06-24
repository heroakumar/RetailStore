using RetailStore.Core.Entity; 
using System;

namespace RetailStore.Core.Extention
{
    public static class UtilityExtention
    {
        public static bool IsUserEllgibleForLoyaltyDiscount(this User user)
        {
            return (DateTime.Now.Year - user.CreateDate.Year) >= DiscountSettingHelper.LoyaltyEligibilityYear;
        }
    }
}
