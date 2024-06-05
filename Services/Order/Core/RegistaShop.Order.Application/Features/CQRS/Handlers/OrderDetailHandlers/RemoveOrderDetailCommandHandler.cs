using RegistaShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using RegistaShop.Order.Application.Interfaces;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class RemoveOrderDetailCommandHandler
	{

		private readonly IRepository<OrderDetail> _repository;

		public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveOrderDetailCommand command)
		{
			var value = await _repository.GetByIdAsync(command.Id);
			await _repository.DeleteAsync(value);
		}

	}
}
