using DevFreela.Payments.Core.Entities;
using DevFreela.Payments.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Payments.Application.Commands.CreatePayment
{
    public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Unit>
    {
        private readonly IPaymentService _paymentService;
        public CreatePaymentCommandHandler(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public async Task<Unit> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
        {
            Payment payment = new Payment(request.IdProject, request.CreditCardNumber, request.Cvv, request.ExpiresAt, request.FullName, request.Amount);

            await _paymentService.ProcessAsync(payment);

            return Unit.Value;
        }
    }
}
