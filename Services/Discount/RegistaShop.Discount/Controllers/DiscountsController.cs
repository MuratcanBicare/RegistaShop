using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Discount.Dtos;
using RegistaShop.Discount.Services;

namespace RegistaShop.Discount.Controllers
{
	
	public class DiscountsController : ApiBaseController
	{

		private readonly IDiscountService _discountService;

		public DiscountsController(IDiscountService discountService)
		{
			_discountService = discountService;
		}

		[HttpGet]
		public async Task<IActionResult> DiscountCouponList()
		{

			var values = await _discountService.GetAllDiscountCouponAsync();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetDiscountCouponById(int id)
		{

			var values = await _discountService.GetByIdDiscountCouponAsync(id);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDto createCouponDto)
		{
			
			await _discountService.CreateDiscountCouponAysnc(createCouponDto);
			return Ok("İndirim Kuponu başarıyla eklendi.");

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteDiscountCoupon(int id)
		{

			await _discountService.DeleteDiscountCouponAysnc(id);
			return Ok("İndirim Kuponu başarıyla silindi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDto updateCouponDto)
		{

			await _discountService.UpdateDiscountCouponAysnc(updateCouponDto);
			return Ok("İndirim Kuponu başarıyla güncellendi.");

		}

	}
}
