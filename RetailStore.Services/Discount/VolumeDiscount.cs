using System.Collections.Generic;
using RetailStore.Core.Entity;
using System.Linq;
using RetailStore.Core;

namespace RetailStore.Services.Discount
{
    public class VolumeDiscount : IDiscountService
    {
        public decimal CalculateDiscount(List<Product> products)
        {
            int numberOfHundredMultiply = (int)(products.Sum(x => x.Price) / DiscountSettingHelper.DiscountOnSaleVolume);
            return numberOfHundredMultiply * DiscountSettingHelper.SaleVolumeDiscount;
        } 
    }
}
