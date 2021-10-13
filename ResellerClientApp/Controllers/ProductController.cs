using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reseller.Core.Dtos;
using Reseller.Services.Interfaces;
using Reseller.Services.Interfaces.RuleCalculator;

namespace ResellerClientApp.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IRuleCalculator _ruleCalculator;

        public ProductController(
            IProductService productService, 
            IRuleCalculator ruleCalculator)
        {
            _productService = productService;
            _ruleCalculator = ruleCalculator;
        }

        /// <summary>
        /// a list of products with standard prices
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
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
