using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Reseller.Core.Entities
{
    public class Purchase : BaseEntity
    {
        public double UnitPurchasePrice { get; set; }
        public double UnitCount { get; set; }
        public Product Product { get; set; }
    }
}
