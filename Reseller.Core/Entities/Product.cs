using Reseller.Core.Enums;

namespace Reseller.Core.Entities
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public double  NetValue { get; set; }
        public double  TaxRate { get; set; }
        public ProductType ProductType { get; set; }
    }
}
