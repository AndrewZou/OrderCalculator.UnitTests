using System;
using Xunit;
using OrderCalculator;
using System.Collections.Generic;

//At this time, the business needs implementation for 5 clients that will use this application. 
//1 from GA, 1 from FL, 1 from NY, 1 from NM, and 1 from NV.
namespace OrderCalculator.UnitTest
{
    public class OrderCalculatorTests
    {
        [Fact]
        public void Test_OrderCalculation()
        {
            Product product = new Product {
                Code = "12345",
                Name = "Monitor",
                Type = Type.Luxury,
                UnitPrice = 200.00                
            };

            Coupon coupon = new Coupon
            {
                Code = "54321",
                ProductCode = "12345",
                DeductAmount = 50.00,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            Promotion promotion = new Promotion
            {
                Code = "54321",
                ProductCode = "456789",
                DeductRate = 0.10,
                ExpirationDate = DateTime.Now.AddDays(10)
            };

            Order order = new Order
            {
                CustomerId = "ABCDEFG",
                State = "FL",
                productsBasket = new List<Product>(),
                appliedCoupons = new List<Coupon>(),
                appliedPromotions = new List<Promotion>()
            };

            order.AddProduct(product);
            order.AddCoupon(coupon);
            order.AddPromotion(promotion);

            OrderCalculator calculator = new OrderCalculator
            {
                CustomerOrder = order
            };


            calculator.calculateOrderPayment();
            Assert.Equal(32.00, calculator.CustomerOrder.TaxCharge);
            Assert.Equal(150.00, calculator.CustomerOrder.TotalCost);
        }

        [Fact]
        public void Test_OrderCalculation1()
        {
            Product product = new Product
            {
                Code = "12345",
                Name = "Monitor",
                Type = Type.Normal,
                UnitPrice = 200.00
            };

            Coupon coupon = new Coupon
            {
                Code = "54321",
                ProductCode = "12345",
                DeductAmount = 50.00,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            Promotion promotion = new Promotion
            {
                Code = "54321",
                ProductCode = "456789",
                DeductRate = 0.10,
                ExpirationDate = DateTime.Now.AddDays(10)
            };

            Order order = new Order
            {
                CustomerId = "ABCDEFG",
                State = "NY",
                productsBasket = new List<Product>(),
                appliedCoupons = new List<Coupon>(),
                appliedPromotions = new List<Promotion>()
            };

            order.AddProduct(product);
            order.AddCoupon(coupon);
            order.AddPromotion(promotion);

            OrderCalculator calculator = new OrderCalculator
            {
                CustomerOrder = order
            };


            calculator.calculateOrderPayment();
            Assert.Equal(12.00, calculator.CustomerOrder.TaxCharge);
            Assert.Equal(150.00, calculator.CustomerOrder.TotalCost);
        }

        [Fact]
        public void Test_OrderCalculation2()
        {
            Product product = new Product
            {
                Code = "12345",
                Name = "Monitor",
                Type = Type.Luxury,
                UnitPrice = 200.00
            };

            Coupon coupon = new Coupon
            {
                Code = "54321",
                ProductCode = "12345",
                DeductAmount = 50.00,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            Promotion promotion = new Promotion
            {
                Code = "54321",
                ProductCode = "456789",
                DeductRate = 0.10,
                ExpirationDate = DateTime.Now.AddDays(10)
            };

            Order order = new Order
            {
                CustomerId = "ABCDEFG",
                State = "FL",
                productsBasket = new List<Product>(),
                appliedCoupons = new List<Coupon>(),
                appliedPromotions = new List<Promotion>()
            };

            order.AddProduct(product);
            order.AddCoupon(coupon);
            order.AddPromotion(promotion);

            OrderCalculator calculator = new OrderCalculator
            {
                CustomerOrder = order
            };


            calculator.calculateOrderPayment();
            Assert.Equal(32.00, calculator.CustomerOrder.TaxCharge);
            Assert.Equal(150.00, calculator.CustomerOrder.TotalCost);
        }

        [Fact]
        public void Test_OrderCalculation3()
        {
            Product product = new Product
            {
                Code = "12345",
                Name = "Monitor",
                Type = Type.Luxury,
                UnitPrice = 200.00
            };

            Coupon coupon = new Coupon
            {
                Code = "54321",
                ProductCode = "12345",
                DeductAmount = 50.00,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            Promotion promotion = new Promotion
            {
                Code = "54321",
                ProductCode = "456789",
                DeductRate = 0.10,
                ExpirationDate = DateTime.Now.AddDays(10)
            };

            Order order = new Order
            {
                CustomerId = "ABCDEFG",
                State = "NM",
                productsBasket = new List<Product>(),
                appliedCoupons = new List<Coupon>(),
                appliedPromotions = new List<Promotion>()
            };

            order.AddProduct(product);
            order.AddCoupon(coupon);
            order.AddPromotion(promotion);

            OrderCalculator calculator = new OrderCalculator
            {
                CustomerOrder = order
            };


            calculator.calculateOrderPayment();
            Assert.Equal(32.00, calculator.CustomerOrder.TaxCharge);
            Assert.Equal(150.00, calculator.CustomerOrder.TotalCost);
        }

        [Fact]
        public void Test_OrderCalculation4()
        {
            Product product = new Product
            {
                Code = "12345",
                Name = "Monitor",
                Type = Type.Luxury,
                UnitPrice = 200.00
            };

            Coupon coupon = new Coupon
            {
                Code = "54321",
                ProductCode = "12345",
                DeductAmount = 50.00,
                ExpirationDate = DateTime.Now.AddDays(14)
            };

            Promotion promotion = new Promotion
            {
                Code = "54321",
                ProductCode = "456789",
                DeductRate = 0.10,
                ExpirationDate = DateTime.Now.AddDays(10)
            };

            Order order = new Order
            {
                CustomerId = "ABCDEFG",
                State = "NV",
                productsBasket = new List<Product>(),
                appliedCoupons = new List<Coupon>(),
                appliedPromotions = new List<Promotion>()
            };

            order.AddProduct(product);
            order.AddCoupon(coupon);
            order.AddPromotion(promotion);

            OrderCalculator calculator = new OrderCalculator
            {
                CustomerOrder = order
            };


            calculator.calculateOrderPayment();
            Assert.Equal(32.00, calculator.CustomerOrder.TaxCharge);
            Assert.Equal(150.00, calculator.CustomerOrder.TotalCost);
        }
    }
}

