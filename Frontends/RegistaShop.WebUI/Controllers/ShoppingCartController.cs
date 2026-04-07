using Microsoft.AspNetCore.Mvc;
using RegistaShop.DtoLayer.BasketDtos;
using RegistaShop.WebUI.Services.BasketServices;
using RegistaShop.WebUI.Services.CatalogServices.ProductServices;

namespace RegistaShop.WebUI.Controllers
{
	public class ShoppingCartController : Controller
	{

		private readonly IProductService _productService;
		private readonly IBasketService _basketService;

		public ShoppingCartController(IProductService productService, IBasketService basketService)
		{
			_productService = productService;
			_basketService = basketService;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _basketService.GetBasket();
			return View(values);
		}

		public async Task<IActionResult> AddBasketItem(string productId)
		{
			var values = await _productService.GetByIdProductAsync(productId);
			var items = new BasketItemDto
			{
				ProductId = values.ProductId,
				ProductName = values.ProductName,
				Price = values.ProductPrice,
				Quantity = 1
			};

			await _basketService.AddBasketItem(items);
			return RedirectToAction("Index");

		}

		public async Task<IActionResult> RemoveBasketItem(string productId)
		{
			await _basketService.RemoveBasketItem(productId);
			return RedirectToAction("Index");
		}

	}
}
