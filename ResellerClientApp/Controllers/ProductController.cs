using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reseller.Core.Dtos;
using Reseller.Services.Interfaces;

namespace ResellerClientApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// a list of products with standard prices
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProducts();
            // TODO map to dto with Automapper
            var productsDto = new List<ProductDto>();

            foreach (var product in products)
            {
                productsDto.Add(new ProductDto()
                {
                    Id = product.Id,
                    ProductName = product.ProductName,
                    NetValue = product.NetValue,
                    ProductType = product.ProductType,
                    // gross value
                    TaxRate = product.TaxRate
                });
            }

            return Ok(productsDto);
        }
    }
}
