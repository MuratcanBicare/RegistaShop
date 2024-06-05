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
	public class CreateOrderDetailCommandHandler
	{

		private readonly IRepository<OrderDetail> _repository;

		public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateOrderDetailCommand command)
		{

			await _repository.CreateAsync(new OrderDetail
			{

				OrderDetailId = command.OrderingId,
				ProductId = command.ProductId,
				ProductName = command.ProductName,
				ProductAmount = command.ProductAmount,
				ProductPrice = command.ProductPrice,
				ProductTotalPrice = command.ProductTotalPrice,

			});

		}
	}
}