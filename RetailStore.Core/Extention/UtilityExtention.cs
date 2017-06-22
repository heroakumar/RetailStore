using RetailStore.Core.Entity;
using System;

namespace RetailStore.Core.Extention
{
    public static class UtilityExtention
    {
        public static bool IsUserEllgibleForLoyaltyDiscount(this User user)
        {
            return (user.CreateDate.Year - DateTime.Now.Year) > 2;
        }
    }
}
