using System;
using System.Collections.Generic;
using System.Text;
using Reseller.Core.Enums;

namespace Reseller.Core.Dtos
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public double NetValue { get; set; }
        public double TaxRate { get; set; }
        public ProductType ProductType { get; set; }
    }
}
