using System.Collections.Generic;
using System.Linq;
using Reseller.Core.Entities;
using Reseller.Services.Interfaces.RuleCalculator;

namespace Reseller.Services.Implementations.RuleCalculator.Strategies
{
    public class DiscountStrategy : IRuleCalculatorStrategy
    {
        public double Calculate(IEnumerable<Product> products)
        {
            // TODO add logic based on DiscountPolicies or CustomerAgreements
            return products.Sum(product => product.NetValue) * 0.9;
        }
    }
}