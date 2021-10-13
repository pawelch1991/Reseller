using System;

namespace Reseller.Core.Entities
{
    public class Order : BaseEntity
    {
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public double Count { get; set; }
        public double NetValue { get; set; }
        public double Tax { get; set; }
        public double GrossValue { get; set; }
    }
}
