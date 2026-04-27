using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.OrderViewComponent
{
	public class _PaymentMethodComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
