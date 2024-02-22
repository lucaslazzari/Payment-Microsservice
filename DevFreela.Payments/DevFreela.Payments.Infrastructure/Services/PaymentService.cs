using DevFreela.Payments.Core.Entities;
using DevFreela.Payments.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Payments.Infrastructure.Services
{
    public class PaymentService : IPaymentService
    {
        public async Task<bool> ProcessAsync(Payment payment)
        {
            return await Task.FromResult(true);
        }
    }
}
