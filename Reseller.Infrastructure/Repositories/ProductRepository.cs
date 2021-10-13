using System;
using System.Collections.Generic;
using System.Text;
using Reseller.Core.Entities;
using Reseller.Core.Enums;

namespace Reseller.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            // mock data not using dbContext

            return new List<Product>()
            {
                new Product()
                {
                   CreateDate = DateTime.UtcNow,
                   Id = Guid.NewGuid(),
                   LastUpdate = DateTime.UtcNow,
                   NetValue = 100.25,
                   ProductName = "test product",
                   ProductType = ProductType.Wardrobe,
                   TaxRate = 23
                }
            };
        }
    }
}
