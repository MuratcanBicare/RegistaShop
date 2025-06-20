using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Cargo.BusinessLayer.Abstarct;
using RegistaShop.Cargo.DtoLayer.Dtos.CargoDetailDtos;
using RegistaShop.Cargo.EntityLayer.Concrete;

namespace RegistaShop.Cargo.WebApi.Controllers
{
	public class CargoDetailsController : ApiBaseController
	{

		private readonly ICargoDetailService _cargoDetailService;

		public CargoDetailsController(ICargoDetailService cargoDetailService)
		{
			_cargoDetailService = cargoDetailService;
		}

		[HttpGet]
		public IActionResult CargoDetailList()
		{
			var values = _cargoDetailService.TGetAll();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult CreateCargoDetail(CreateCargoDetailDto createCargoDetailDto)
		{
			CargoDetail cargoDetail = new CargoDetail()
			{
				SenderCustomer = createCargoDetailDto.SenderCustomer,
				ReceiverCustomer = createCargoDetailDto.ReceiverCustomer,
				Barcode = createCargoDetailDto.Barcode,
				CargoCompanyId = createCargoDetailDto.CargoCompanyId
			};

			_cargoDetailService.TInsert(cargoDetail);
			return Ok("Kargo Detayları Başarıyla Oluşturuldu.");
		}

		[HttpDelete]
		public IActionResult RemoveCargoDetail(int id)
		{
			_cargoDetailService.TDelete(id);
			return Ok("Kargo Detayları Başarıyla Silindi.");
		}

		[HttpGet("{id}")]
		public IActionResult GetCargoDetailById(int id)
		{
			var values = _cargoDetailService.TGetById(id);
			return Ok(values);
		}

		[HttpPut]
		public IActionResult UpdateCargoDetail(UpdateCargoDetailDto updateCargoDetailDto)
		{
			CargoDetail cargoDetail = new CargoDetail()
			{
				CargoDetailId = updateCargoDetailDto.CargoDetailId,
				SenderCustomer = updateCargoDetailDto.SenderCustomer,
				ReceiverCustomer = updateCargoDetailDto.ReceiverCustomer,
				Barcode = updateCargoDetailDto.Barcode,
				CargoCompanyId = updateCargoDetailDto.CargoCompanyId
			};

			_cargoDetailService.TUpdate(cargoDetail);
			return Ok("Kargo Detayları Başarıyla Güncellendi.");
		}

	}
}
