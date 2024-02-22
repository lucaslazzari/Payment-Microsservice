using DevFreela.Payments.Application.Commands.CreatePayment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Payments.API.Controllers
{
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PaymentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreatePaymentCommand command)
        {
            await _mediator.Send(command);

            return NoContent();
        }
    }
}
