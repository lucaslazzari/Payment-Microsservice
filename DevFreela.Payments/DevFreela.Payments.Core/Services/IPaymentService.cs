using DevFreela.Payments.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Payments.Core.Services
{
    public interface IPaymentService
    {
        Task<bool> ProcessAsync(Payment payment);
    }
}
