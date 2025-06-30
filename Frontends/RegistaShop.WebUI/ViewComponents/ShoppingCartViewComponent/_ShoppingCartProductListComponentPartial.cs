using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.ShoppingCartViewComponent
{
	public class _ShoppingCartProductListComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
