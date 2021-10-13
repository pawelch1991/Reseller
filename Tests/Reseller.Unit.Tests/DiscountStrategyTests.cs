using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Reseller.Core.Entities;
using Reseller.Core.Enums;
using Reseller.Services.Implementations.RuleCalculator.Strategies;
using Xunit;

namespace Reseller.Services.Unit.Tests
{
    public class DiscountStrategyTests
    {
        [Fact]
        public void Calculate_WhenGivenProducts_ReturnsLowerPrice()
        {
            // Arrange
            var calculationStrategy = new DiscountStrategy();
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CreateDate = DateTime.UtcNow,
                    LastUpdate = DateTime.UtcNow,
                    NetValue = 100.00,
                    ProductName = "Product1",
                    ProductType = ProductType.Wardrobe,
                    TaxRate = 0.23
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CreateDate = DateTime.UtcNow,
                    LastUpdate = DateTime.UtcNow,
                    NetValue = 200.00,
                    ProductName = "Product2",
                    ProductType = ProductType.Wardrobe,
                    TaxRate = 0.23
                }
            };
            
            // Act 
            var result = calculationStrategy.Calculate(products);
            
            // Assert
            result.Should().BeLessThan(products.Sum(product => product.NetValue));
        }
    }
}
