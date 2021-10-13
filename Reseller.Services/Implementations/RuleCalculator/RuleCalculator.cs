using System.Collections.Generic;
using Reseller.Core.Entities;
using Reseller.Core.Enums;
using Reseller.Services.Interfaces.RuleCalculator;

namespace Reseller.Services.Implementations.RuleCalculator
{
    public class RuleCalculator : IRuleCalculator
    {
        private readonly Dictionary<Rule, IRuleCalculatorStrategy> _calculationStrategies;

        public RuleCalculator(Dictionary<Rule, IRuleCalculatorStrategy> calculationStrategies)
        {
            _calculationStrategies = calculationStrategies;
        }

        public double Calculate(Rule rule, IEnumerable<Product> usage)
        {
            return _calculationStrategies[rule].Calculate(usage);
        }
    }
}