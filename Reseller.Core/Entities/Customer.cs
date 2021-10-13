using System.Reflection.Metadata;

namespace Reseller.Core.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string Country { get; set; }
    }
}
