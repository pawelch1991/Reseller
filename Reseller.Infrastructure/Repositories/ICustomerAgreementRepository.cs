using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Reseller.Core.Entities;

namespace Reseller.Infrastructure.Repositories
{
    public interface  ICustomerAgreementRepository
    {
        Task<IEnumerable<CustomerAgreement>> GetCustomers();
    }
}
