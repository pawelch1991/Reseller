using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Reseller.Core.Enums;

namespace Reseller.Core.Entities
{
    public class DiscountPolicy : BaseEntity
    {
        public ProductType ProductType { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public double ValuePercentage { get; set; }
    }
}
