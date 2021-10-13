using System;
using System.Collections.Generic;
using System.Text;

namespace Reseller.Core.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdate { get; set; }
    }
}
