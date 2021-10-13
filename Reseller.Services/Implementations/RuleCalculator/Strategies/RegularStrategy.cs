using System.Collections.Generic;
using System.Linq;
using Reseller.Core.Entities;
using Reseller.Services.Interfaces.RuleCalculator;

namespace Reseller.Services.Implementations.RuleCalculator.Strategies
{
    public class RegularStrategy : IRuleCalculatorStrategy
    {
        public double Calculate(IEnumerable<Product> products)
        {
            return products.Sum(x => x.NetValue);
        }
    }
}