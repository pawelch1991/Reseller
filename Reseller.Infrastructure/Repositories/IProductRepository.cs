using System;
using System.Collections.Generic;
using System.Text;
using Reseller.Core.Entities;

namespace Reseller.Infrastructure.Repositories
{
    // this code should be refactored with generic repository if used actual dbContext
    // https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application#implement-a-generic-repository-and-a-unit-of-work-class
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
