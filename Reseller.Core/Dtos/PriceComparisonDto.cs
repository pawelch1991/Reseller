using System;
using System.Collections.Generic;
using System.Text;

namespace Reseller.Core.Dtos
{
    public class PriceComparisonDto
    {
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
    }
}
