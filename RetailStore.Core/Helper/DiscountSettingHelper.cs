using System.Configuration;

namespace RetailStore.Core
{
    public static class DiscountSettingHelper
    {
        public readonly static decimal EmployeeDiscount = decimal.Parse(ConfigurationManager.AppSettings["EmployeeDiscount"]);
        public readonly static decimal AffilateDiscount = decimal.Parse(ConfigurationManager.AppSettings["AffilateDiscount"]);
        public readonly static decimal LoyaltyEligibilityYear = decimal.Parse(ConfigurationManager.AppSettings["LoyaltyEligibilityYear"]);
        public readonly static decimal LoyelityDiscount = decimal.Parse(ConfigurationManager.AppSettings["LoyelityDiscount"]);
        public readonly static decimal SaleVolumeDiscount = decimal.Parse(ConfigurationManager.AppSettings["SaleVolumeDiscount"]);
        public readonly static decimal DiscountOnSaleVolume = decimal.Parse(ConfigurationManager.AppSettings["DiscountOnSaleVolume"]);

    }
}
