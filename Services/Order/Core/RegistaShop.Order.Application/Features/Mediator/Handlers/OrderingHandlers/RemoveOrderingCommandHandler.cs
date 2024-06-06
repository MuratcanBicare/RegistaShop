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
	public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
	{

		private readonly IRepository<Ordering> _repository;

		public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);
			await _repository.DeleteAsync(value);

		}
	}
}
