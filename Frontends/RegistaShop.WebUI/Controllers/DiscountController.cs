using Microsoft.AspNetCore.Mvc;
using RegistaShop.WebUI.Services.BasketServices;
using RegistaShop.WebUI.Services.DiscountServices;
using System.Threading.Tasks;

namespace RegistaShop.WebUI.Controllers
{
	public class DiscountController : Controller
	{

		private readonly IDiscountService _discountService;
		private readonly IBasketService _basketService;

		public DiscountController(IDiscountService discountService, IBasketService basketService)
		{
			_discountService = discountService;
			_basketService = basketService;
		}

		[HttpGet]
		public PartialViewResult ConfirmDiscountCoupon()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> ConfirmDiscountCoupon(string code)
		{
			var values = await _discountService.GetDiscountCouponRate(code);
			var basketValues = await _basketService.GetBasket();

			var totalWithTax = basketValues.TotalPrice + basketValues.TotalPrice / 100 * 10;
			var discountedTotal = totalWithTax - (totalWithTax / 100 * values);
			ViewBag.discountedTotal = discountedTotal;

			return RedirectToAction("Index", "ShoppingCart", new { code = code, rate = values, discountedTotal = discountedTotal});

		}
	}
}
