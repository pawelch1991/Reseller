using Autofac;
using Reseller.Services.Implementations;

namespace Reseller.Services.Modules
{
    public class ServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductService>().AsImplementedInterfaces().InstancePerDependency();
            // register discountStrategy
        }
    }
}
