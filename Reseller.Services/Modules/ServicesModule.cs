using System.Collections.Generic;
using Autofac;
using Reseller.Core.Enums;
using Reseller.Services.Implementations;
using Reseller.Services.Implementations.RuleCalculator;
using Reseller.Services.Implementations.RuleCalculator.Strategies;
using Reseller.Services.Interfaces.RuleCalculator;

namespace Reseller.Services.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().AsImplementedInterfaces().InstancePerDependency();
            
            // register discountStrategy
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(x => x.IsAssignableTo<IRuleCalculatorStrategy>())
                .AsSelf()
                .InstancePerLifetimeScope();

            builder.Register(x => new Dictionary<Rule, IRuleCalculatorStrategy>
                {
                    {Rule.Discount, x.Resolve<DiscountStrategy>()},
                    {Rule.RegularPrice, x.Resolve<RegularStrategy>()}
                })
                .As(typeof(Dictionary<Rule, IRuleCalculatorStrategy>))
                .SingleInstance();

            builder.RegisterType<RuleCalculator>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
