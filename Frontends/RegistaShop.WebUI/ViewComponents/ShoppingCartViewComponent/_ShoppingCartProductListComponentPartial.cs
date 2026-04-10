using Microsoft.AspNetCore.Mvc;
using RegistaShop.WebUI.Services.BasketServices;
using System.Threading.Tasks;

namespace RegistaShop.WebUI.ViewComponents.ShoppingCartViewComponent
{
	public class _ShoppingCartProductListComponentPartial : ViewComponent
	{

		private readonly IBasketService _basketService;

		public _ShoppingCartProductListComponentPartial(IBasketService basketService)
		{
			_basketService = basketService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var basketTotal = await _basketService.GetBasket();
			var basketItems = basketTotal.BasketItems;
			return View(basketItems);
		}

	}
}
