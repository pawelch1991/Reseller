using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Reseller.Infrastructure.Database;
using Reseller.Infrastructure.Repositories;

namespace Reseller.Infrastructure.Modules
{
    public class DatabaseModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

                builder.Register(c =>
                {
                    var config = c.Resolve<IConfiguration>();

                    var opt = new DbContextOptionsBuilder<ResellerContext>();
                    opt.UseSqlServer(config.GetConnectionString("ResellerContext"));

                    return new ResellerContext(opt.Options);
                })
                .AsSelf()
                .InstancePerLifetimeScope();

        }
    }
}
