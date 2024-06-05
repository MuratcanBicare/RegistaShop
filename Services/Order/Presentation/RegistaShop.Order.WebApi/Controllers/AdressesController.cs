﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using RegistaShop.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using RegistaShop.Order.Application.Features.CQRS.Queries.AddressQueries;

namespace RegistaShop.Order.WebApi.Controllers
{
	public class AdressesController : ApiBaseController
	{

		private readonly GetAddressQueryHandler _getAddressQueryHandler;
		private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
		private readonly CreateAddressCommandHandler _createAddressCommandHandler;
		private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;
		private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;

		public AdressesController(GetAddressQueryHandler getAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler, RemoveAddressCommandHandler removeAddressCommandHandler)
		{
			_getAddressQueryHandler = getAddressQueryHandler;
			_getAddressByIdQueryHandler = getAddressByIdQueryHandler;
			_createAddressCommandHandler = createAddressCommandHandler;
			_updateAddressCommandHandler = updateAddressCommandHandler;
			_removeAddressCommandHandler = removeAddressCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> AddressList()
		{

			var values = await _getAddressQueryHandler.Handle();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAddressById(int id)
		{

			var value = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
			return Ok(value);

		}

		[HttpPost]
		public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
		{

			await _createAddressCommandHandler.Handle(command);
			return Ok("Adres bilgisi başarılı bir şekilde eklendi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
		{
			await _updateAddressCommandHandler.Handle(command);
			return Ok("Adres bilgisi başarılı bir şekilde güncellendi.");
		}

		[HttpDelete]
		public async Task<IActionResult> RemoveAddress(int id)
		{

			await _removeAddressCommandHandler.Handle(new RemoveAddressCommand(id));
			return Ok("Adres bilgisi başarılı bir şekilde silindi.");

		}
	}
}
