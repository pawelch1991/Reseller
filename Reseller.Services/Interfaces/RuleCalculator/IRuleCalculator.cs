using System.Collections.Generic;
using Reseller.Core.Entities;
using Reseller.Core.Enums;

namespace Reseller.Services.Interfaces.RuleCalculator
{
    public interface IRuleCalculator
    {
        double Calculate(Rule rule, IEnumerable<Product> products);
    }
}