using RetailStore.Core;
using RetailStore.Core.Entity;
using RetailStore.Data;
using RetailStore.Data.Repositories;
using RetailStore.Services.Discount;
using RetailStore.Services.Resolver;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RetailStore.Tests
{
    public class DiscountTests
    { 
        IProductRepository productRepository;
        IUserRepository userRepository;
        User employee;
        User affilate;
        User customerNew;
        User customerOld;
        List<Product> products;

        public DiscountTests()
        {
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
            //When the user will login role of user will be passed to resolver to get applicable discounts
            var discountservices = DiscountServiceResolver.DiscountServices(employee); 
            var discount = new DiscountService(discountservices).GetTotalDiscount(products);
            Assert.Equal(4415, discount); 
        }

        [Fact]
        public void ShouldApply10PercentsDiscountForAffilate()
        {
            //When the user will login role of user will be passed to resolver to get applicable discounts
            var discountservices = DiscountServiceResolver.DiscountServices(affilate);
            var discount = new DiscountService(discountservices).GetTotalDiscount(products);
            Assert.Equal(1895, discount); 
        }

        [Fact]
        public void ShouldApplyOnlyVolumeDiscountForCustomerNew()
        {
            //When the user will login role of user will be passed to resolver to get applicable discounts
            var discountservices = DiscountServiceResolver.DiscountServices(customerNew);
            var discount = new DiscountService(discountservices).GetTotalDiscount(products);  
            Assert.Equal(635, discount);
        }

        [Fact]
        public void ShouldApply5PercentsDiscountForCustomerOld()
        {
            //When the user will login role of user will be passed to resolver to get applicable discounts
            var discountservices = DiscountServiceResolver.DiscountServices(customerOld);
            var discount = new DiscountService(discountservices).GetTotalDiscount(products);
            Assert.Equal(1265, discount);
        }
    } 
}
