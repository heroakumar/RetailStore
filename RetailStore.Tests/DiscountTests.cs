using RetailStore.Core.Entity;
using RetailStore.Data;
using RetailStore.Data.Repositories;
using RetailStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RetailStore.Tests
{
    public class DiscountTests
    {
        IDiscountService discountService;
        IProductRepository productRepository;
        IUserRepository userRepository;
        User employee;
        User affilate;
        User customerNew;
        User customerOld;
        List<Product> products;

        public DiscountTests()
        {
            discountService = new DiscountService();
            productRepository = new ProductRepository();

            products = productRepository.Get();

            userRepository = new UserRepository();

            employee = userRepository.GetByRole(Role.EMPLOYEE).FirstOrDefault();
            affilate = userRepository.GetByRole(Role.AFFILATE).FirstOrDefault();
            var customers = userRepository.GetByRole(Role.CUSTOMER);

            customerNew = customers.FirstOrDefault(x => (DateTime.Now.Year - x.CreateDate.Year) < DiscountSettingHelper.LoyaltyEligibilityYear);

            customerOld = customers.FirstOrDefault(x => (DateTime.Now.Year - x.CreateDate.Year) >= DiscountSettingHelper.LoyaltyEligibilityYear);

        } 

        [Fact]
        public void ShouldApply30PercentsDiscountForEmployee()
        {
            var discount = discountService.CalculateDiscount(employee, products);
            Assert.Equal(30, discount.PercentileDiscount);
            Assert.Equal(635, discount.VolumeDiscount);
        }

        [Fact]
        public void ShouldApply10PercentsDiscountForAffilate()
        {
            var discount = discountService.CalculateDiscount(affilate, products);
            Assert.Equal(10, discount.PercentileDiscount);
            Assert.Equal(635, discount.VolumeDiscount);
        }

        [Fact]
        public void ShouldApplyOnlyVolumeDiscountForCustomerNew()
        {
            var discount = discountService.CalculateDiscount(customerNew, products);
            Assert.Equal(0, discount.PercentileDiscount);
            Assert.Equal(635, discount.VolumeDiscount);
        }

        [Fact]
        public void ShouldApply5PercentsDiscountForCustomerOld()
        {
            var discount = discountService.CalculateDiscount(customerOld, products);
            Assert.Equal(5, discount.PercentileDiscount);
            Assert.Equal(635, discount.VolumeDiscount);
        }
    }

}
