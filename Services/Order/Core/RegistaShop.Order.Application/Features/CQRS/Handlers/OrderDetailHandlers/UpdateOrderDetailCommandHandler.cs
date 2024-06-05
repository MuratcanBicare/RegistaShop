﻿using RegistaShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using RegistaShop.Order.Application.Interfaces;
using RegistaShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistaShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
	public class UpdateOrderDetailCommandHandler
	{

		private readonly IRepository<OrderDetail> _repository;

		public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderDetailCommand command)
		{

			var values = await _repository.GetByIdAsync(command.OrderDetailId);
			values.OrderingId = command.OrderingId;
			values.ProductId = command.ProductId;
			values.ProductName = command.ProductName;
			values.ProductPrice = command.ProductPrice;
			values.ProductAmount = command.ProductAmount;
			values.ProductTotalPrice = command.ProductTotalPrice;
			await _repository.UpdateAsync(values);



		}
	}
}
