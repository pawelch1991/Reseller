using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Reseller.Core.Dtos;
using Reseller.Core.Enums;
using Reseller.Services.Interfaces;
using Reseller.Services.Interfaces.RuleCalculator;
using Swashbuckle.AspNetCore.Annotations;

namespace Reseller.WebApi.Controllers
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
        // TODO remove AllowAnonymous - it's for easing development only
        [AllowAnonymous]
        [HttpGet]
        [SwaggerOperation(Description = "Returns a list of products with standard prices")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProducts();

            var sumRegular = _ruleCalculator.Calculate(Rule.RegularPrice, products);
            var sumDiscount = _ruleCalculator.Calculate(Rule.Discount, products);

            var priceComparison = new PriceComparisonDto()
            {
                DiscountPrice = sumDiscount,
                RegularPrice = sumRegular
            };
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

            return Ok(new {productsDto, priceComparison});
        }
    }
}
