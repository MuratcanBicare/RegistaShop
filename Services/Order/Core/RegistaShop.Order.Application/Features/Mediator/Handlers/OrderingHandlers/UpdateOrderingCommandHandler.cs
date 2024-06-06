using MediatR;
using RegistaShop.Order.Application.Features.Mediator.Commands.OrderingCommands;
using RegistaShop.Order.Application.Interfaces;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
	{

		private readonly IRepository<Ordering> _repository;

		public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
		{

			var value = await _repository.GetByIdAsync(request.OrderingId);
			value.OrderDate = request.OrderDate;
			value.UserId = request.UserId;
			value.TotalPrice = request.TotalPrice;
			await _repository.UpdateAsync(value);

		}
	}
}
