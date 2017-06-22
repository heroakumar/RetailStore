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
        //. If the user is an employee of the store, he gets a 30% discount 
        //2. If the user is an affiliate of the store, he gets a 10% discount 
        //3. If the user has been a customer for over 2 years, he gets a 5% discount.
        //4. For every $100 on the bill, there would be a $ 5 discount(e.g. for $ 990, you get $ 45 as a discount). 
        //5. The percentage based discounts do not apply on groceries.

        [Fact]
        public void ShouldApply30PercentsDiscountForEmployee()
        {
            var discount = discountService.CalculateDiscount(employee, products);
            Assert.Equal(30, discount.PercentileDiscount);
            Assert.Equal(635, discount.TotalAmountDiscount);
        }

        [Fact]
        public void ShouldApply30PercentsDiscountForAffilate()
        {
            var discount = discountService.CalculateDiscount(affilate, products);
            Assert.Equal(10, discount.PercentileDiscount);
            Assert.Equal(635, discount.TotalAmountDiscount);
        }

        [Fact]
        public void ShouldApplyOnlyVolumeDiscountForCustomerNew()
        {
            var discount = discountService.CalculateDiscount(customerNew, products);
            Assert.Equal(0, discount.PercentileDiscount);
            Assert.Equal(635, discount.TotalAmountDiscount);
        }

        [Fact]
        public void ShouldApply5PercentsDiscountForCustomerOld()
        {
            var discount = discountService.CalculateDiscount(customerOld, products);
            Assert.Equal(5, discount.PercentileDiscount);
            Assert.Equal(635, discount.TotalAmountDiscount);
        }
    }

}
