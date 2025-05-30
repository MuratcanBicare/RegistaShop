﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using RegistaShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using RegistaShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;

namespace RegistaShop.Order.WebApi.Controllers
{
	public class OrderDetailsController : ApiBaseController
	{

		private readonly GetOrderDetailQueryHandler _getOrderDetailQueryHandler;
		private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler;
		private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler;
		private readonly UpdateOrderDetailCommandHandler _updateOrderDetailCommandHandler;
		private readonly RemoveOrderDetailCommandHandler _removeOrderDetailCommandHandler;

		public OrderDetailsController(GetOrderDetailQueryHandler getOrderDetailQueryHandler, GetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler, CreateOrderDetailCommandHandler createOrderDetailCommandHandler, UpdateOrderDetailCommandHandler updateOrderDetailCommandHandler, RemoveOrderDetailCommandHandler removeOrderDetailCommandHandler)
		{
			_getOrderDetailQueryHandler = getOrderDetailQueryHandler;
			_getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
			_createOrderDetailCommandHandler = createOrderDetailCommandHandler;
			_updateOrderDetailCommandHandler = updateOrderDetailCommandHandler;
			_removeOrderDetailCommandHandler = removeOrderDetailCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> OrderDetailList()
		{

			var values = await _getOrderDetailQueryHandler.Handle();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrderDetailById(int id)
		{
			var value = await _getOrderDetailByIdQueryHandler.Handle(new GetOrderDetailByIdQuery(id));
			return Ok(value);
		}

		[HttpPost]
		public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
		{

			await _createOrderDetailCommandHandler.Handle(command);
			return Ok("Sipariş detayı başarılı bir şekilde eklendi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateDetailOrder(UpdateOrderDetailCommand command)
		{
			await _updateOrderDetailCommandHandler.Handle(command);
			return Ok("Sipariş detayı başarılı bir şekilde güncellendi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveOrderDetail(int id)
		{

			await _removeOrderDetailCommandHandler.Handle(new RemoveOrderDetailCommand(id));
			return Ok("Sipariş detayı başarılı bir şekilde silindi.");

		}

	}
}
