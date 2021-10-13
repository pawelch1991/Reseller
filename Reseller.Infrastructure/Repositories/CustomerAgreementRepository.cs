using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reseller.Core.Entities;

namespace Reseller.Infrastructure.Repositories
{
    public class CustomerAgreementRepository : ICustomerAgreementRepository
    {
        public async Task<IEnumerable<CustomerAgreement>> GetCustomers()
        {
            return new List<CustomerAgreement>()
            {
                new CustomerAgreement()
                {
                    Customer = new Customer()
                    {

                    },
                    CreateDate = DateTime.UtcNow
                }
            };
        }
    }
}
