using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reseller.Core.Entities;
using Reseller.Services.Interfaces;

namespace Reseller.Services.Implementations
{
    public class ProductService : IProductService
    {
        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
