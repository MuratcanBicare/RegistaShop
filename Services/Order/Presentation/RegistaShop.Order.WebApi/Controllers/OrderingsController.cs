using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using RegistaShop.Order.Application.Features.Mediator.Queries.OrderingQueries;

namespace RegistaShop.Order.WebApi.Controllers
{
	public class OrderingsController : ApiBaseController
	{
		private readonly IMediator _mediator;

		public OrderingsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> OrderingList()
		{

			var values = await _mediator.Send(new GetOrderingQuery());
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrderingById(int id)
		{

			var value = await _mediator.Send(new GetOrderingByIdQuery(id));
			return Ok(value);

		}

		[HttpPost]
		public async Task<IActionResult> CreateOrdering(CreateOrderingCommand command)
		{

			await _mediator.Send(command);
			return Ok("Sipariş başarılı şekilde eklendi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Sipariş başarılı şekilde güncellendi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemeoveOrdering(int id)
		{

			await _mediator.Send(new RemoveOrderingCommand(id));
			return Ok("Sipariş başarılı şekilde silindi.");

		}


	}
}
