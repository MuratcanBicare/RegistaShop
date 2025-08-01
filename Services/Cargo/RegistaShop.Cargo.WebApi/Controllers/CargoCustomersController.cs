﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Cargo.BusinessLayer.Abstarct;
using RegistaShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using RegistaShop.Cargo.EntityLayer.Concrete;

namespace RegistaShop.Cargo.WebApi.Controllers
{
	
	public class CargoCustomersController : ApiBaseController
	{

		private readonly ICargoCustomerService _cargoCustomerService;

		public CargoCustomersController(ICargoCustomerService cargoCustomerService)
		{
			_cargoCustomerService = cargoCustomerService;
		}

		[HttpGet]
		public IActionResult CargoCustomerList()
		{
			var values = _cargoCustomerService.TGetAll();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoCustomerById(int id)
		{
			var values = _cargoCustomerService.TGetById(id);
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = createCargoCustomerDto.Address,
				City = createCargoCustomerDto.City,
				District = createCargoCustomerDto.District,
				Email = createCargoCustomerDto.Email,
				Name  = createCargoCustomerDto.Name,
				Phone = createCargoCustomerDto.Phone,
				Surname = createCargoCustomerDto.Surname
			};
			_cargoCustomerService.TInsert(cargoCustomer);
			return Ok("Kargo Müşteri Ekleme İşlemi Başarıyla Yapıldı.");
		}

		[HttpDelete]
		public IActionResult RemoveCargoCustomer(int id)
		{
			_cargoCustomerService.TDelete(id);
			return Ok("Kargo Müşteri Silme İşlemi Başarıyla Yapıldı.");
		}

		[HttpPut]
		public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
				Address = updateCargoCustomerDto.Address,
				City = updateCargoCustomerDto.City,
				District = updateCargoCustomerDto.District,
				Email = updateCargoCustomerDto.Email,
				Name  = updateCargoCustomerDto.Name,
				Phone = updateCargoCustomerDto.Phone,
				Surname = updateCargoCustomerDto.Surname
			};
			_cargoCustomerService.TUpdate(cargoCustomer);
			return Ok("Kargo Müşteri Güncelleme İşlemi Başarıyla Yapıldı.");
		}
	}
}
