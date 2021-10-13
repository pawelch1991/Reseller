using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reseller.Core.Entities;
using Reseller.Core.Enums;
using Reseller.Services.Interfaces;

namespace Reseller.Services.Implementations
{
    public class ProductService : IProductService
    {
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return new List<Product>()
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
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CreateDate = DateTime.UtcNow,
                    LastUpdate = DateTime.UtcNow,
                    NetValue = 300.00,
                    ProductName = "Product3",
                    ProductType = ProductType.Wardrobe,
                    TaxRate = 0.23
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    CreateDate = DateTime.UtcNow,
                    LastUpdate = DateTime.UtcNow,
                    NetValue = 400.00,
                    ProductName = "Product4",
                    ProductType = ProductType.Wardrobe,
                    TaxRate = 0.23
                }
            };
        }
    }
}
