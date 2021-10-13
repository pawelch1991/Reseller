using System.Collections.Generic;

namespace Reseller.Core.Entities
{
    public class CustomerAgreement : BaseEntity
    {
        public Customer Customer { get; set; }
        public IEnumerable<DiscountPolicy> DiscountPolicies { get; set; }
    }
}
