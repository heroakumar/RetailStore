# RetailStore
The RetailStore app is built to calculate discount on the bill as per user type and type of project

On a retail website, the following discounts apply: 

1. If the user is an employee of the store, he gets a 30% discount.
2. If the user is an affiliate of the store, he gets a 10% discount. 
3. If the user has been a customer for over 2 years, he gets a 5% discount. 
4. For every $100 on the bill, there would be a $ 5 discount (e.g. for $ 990, you get $ 45 as a discount). 
5. The percentage based discounts do not apply on groceries. 
6. A user can get only one of the percentage based discounts on a bill. 


# Getting Started
This project is built in visual studio community addition, to run this project you need to pull this repository. 
xunit is the only package additionally required to run this project, that will be updated via nuget as soon as you build this project

# Prerequisites

you should have visual studion 2015/2017 to run this project.

  
# Running the tests
To run all test RetailStore.Tests project and go to test menu of visual studio Test>Run>All Tests.
Which will run all 4 tests detailed bellow.



Test Case : For Affilate user there will be 10 percentage discount and if user bill amount is greater than 100$ there will be 5$ flat discount on each 100 multiplication amount.
Test Name:	RetailStore.Tests.DiscountTests.ShouldApply10PercentsDiscountForAffilate
Test FullName:	RetailStore.Tests.DiscountTests.ShouldApply10PercentsDiscountForAffilate
Test Source:	D:\RetailStore\RetailStore.Tests\DiscountTests.cs : line 52
Test Outcome:	Passed
Test Duration:	0:00:00.001


Test Case : For Employee there will be 30 percentage discount and if user bill amount is greater than 100$ there will be 5$ flat discount on each 100 multiplication amount.
Test Name:	RetailStore.Tests.DiscountTests.ShouldApply30PercentsDiscountForEmployee
Test FullName:	RetailStore.Tests.DiscountTests.ShouldApply30PercentsDiscountForEmployee
Test Source:	D:\RetailStore\RetailStore.Tests\DiscountTests.cs : line 44
Test Outcome:	Passed
Test Duration:	0:00:00.001


Test Case : For new customer there will not be any percentage discount only volume discount is there, if user bill amount is greater than 100$ there will be 5$ flat discount on each 100 multiplication amount.
Test Name:	RetailStore.Tests.DiscountTests.ShouldApplyOnlyVolumeDiscountForCustomerNew
Test FullName:	RetailStore.Tests.DiscountTests.ShouldApplyOnlyVolumeDiscountForCustomerNew
Test Source:	D:\RetailStore\RetailStore.Tests\DiscountTests.cs : line 60
Test Outcome:	Passed
Test Duration:	0:00:00.049


Test Case : For old customer there will be 10 percentage discount and if user bill amount is greater than 100$ there will be 5$ flat discount on each 100 multiplication amount.
Test Name:	RetailStore.Tests.DiscountTests.ShouldApply5PercentsDiscountForCustomerOld
Test FullName:	RetailStore.Tests.DiscountTests.ShouldApply5PercentsDiscountForCustomerOld
Test Source:	D:\RetailStore\RetailStore.Tests\DiscountTests.cs : line 68
Test Outcome:	Passed
Test Duration:	0:00:00.001

# Flat Discount 
flat discount is calculate on total amount of bill without percentile discount deduction.

 
