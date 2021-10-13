using System.Collections.Generic;
using Reseller.Core.Entities;

namespace Reseller.Services.Interfaces.RuleCalculator
{
    public interface IRuleCalculatorStrategy
    {
        double Calculate(IEnumerable<Product> products);
    }
}