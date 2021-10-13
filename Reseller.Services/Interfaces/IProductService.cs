using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reseller.Core.Dtos;
using Reseller.Core.Entities;

namespace Reseller.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
    }
}
