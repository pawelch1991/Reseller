using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Reseller.Core.Entities
{
    public class Sale : BaseEntity
    {
        public IEnumerable<Order> Orders { get; set; }
        public Customer Customer { get; set; }
    }
}
