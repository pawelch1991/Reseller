using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Reseller.Core.Entities;

namespace Reseller.Infrastructure.Database
{
    public class ResellerContext : DbContext 
    {
        public ResellerContext(DbContextOptions<ResellerContext> options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerAgreement> CustomerAgreements { get; set; }

        public DbSet<DiscountPolicy> DiscountPolicies { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Purchase> Purchases { get; set; }

        public DbSet<Sale> Sales { get; set; }

    }
}
