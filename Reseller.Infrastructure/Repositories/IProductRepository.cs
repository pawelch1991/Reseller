using System;
using System.Collections.Generic;
using System.Text;
using Reseller.Core.Entities;

namespace Reseller.Infrastructure.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
