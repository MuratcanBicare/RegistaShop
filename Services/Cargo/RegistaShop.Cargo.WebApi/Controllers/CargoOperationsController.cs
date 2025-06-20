using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Cargo.BusinessLayer.Abstarct;
using RegistaShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using RegistaShop.Cargo.EntityLayer.Concrete;

namespace RegistaShop.Cargo.WebApi.Controllers
{
	public class CargoOperationsController : ApiBaseController
	{

		private readonly ICargoOperationService _cargoOperationService;

		public CargoOperationsController(ICargoOperationService cargoOperationService)
		{
			_cargoOperationService = cargoOperationService;
		}

		[HttpGet]
		public IActionResult CargoOperationList()
		{
			var values = _cargoOperationService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoOperation(CreateCargoOperationDto createCargoOperationDto)
		{
			CargoOperation cargoOperation = new CargoOperation()
			{
				Barcode = createCargoOperationDto.Barcode,
				OperationDate = createCargoOperationDto.OperationDate,
				Description = createCargoOperationDto.Description
			};

			_cargoOperationService.TInsert(cargoOperation);
			return Ok("Kargo Operasyonu Başarıyla Oluşturuldu.");
		}

		[HttpDelete]
		public IActionResult RemoveCargoOperation(int id)
		{
			_cargoOperationService.TDelete(id);
			return Ok("Kargo Operasyonu Başarıyla Silindi.");
		}
		
		[HttpGet("{id}")]
		public IActionResult GetCargoOperationById(int id)
		{
			var values = _cargoOperationService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoOperation(UpdateCargoOperationDto updateCargoOperationDto)
		{
			CargoOperation cargoOperation = new CargoOperation()
			{
				CargoOperationId = updateCargoOperationDto.CargoOperationId,
				Barcode = updateCargoOperationDto.Barcode,
				Description = updateCargoOperationDto.Description,
				OperationDate = updateCargoOperationDto.OperationDate
			};

			_cargoOperationService.TUpdate(cargoOperation);
			return Ok("Kargo Operasyonu Başarıyla Güncellendi.");
		}

	}
}
