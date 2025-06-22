using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Basket.Dtos;
using RegistaShop.Basket.LoginServices;
using RegistaShop.Basket.Services;

namespace RegistaShop.Basket.Controllers
{

	public class BasketsController : ApiBaseController
	{

		private readonly IBasketService _basketService;
		private readonly ILoginService _loginService;

		public BasketsController(IBasketService basketService, ILoginService loginService)
		{
			_basketService = basketService;
			_loginService = loginService;
		}

		[HttpGet]
		public async Task<IActionResult> GetMyBasketDetail()
		{
			var user = User.Claims;
			var values = await _basketService.GetBasket(_loginService.GetUserId);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> SaveMyBasketDetail(BasketTotalDto basketTotalDto)
		{
			basketTotalDto.UserId = _loginService.GetUserId;
			await _basketService.SaveBasket(basketTotalDto);
			return Ok("Sepetteki değişiklikler kaydedildi.");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteMyBasketDetail()
		{
			await _basketService.DeleteBasket(_loginService.GetUserId);
			return Ok("Sepetiniz başarıyla silindi.");
		}

	}

}
