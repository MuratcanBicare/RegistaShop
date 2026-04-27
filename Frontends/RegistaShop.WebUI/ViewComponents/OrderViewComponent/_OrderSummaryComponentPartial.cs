using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.OrderViewComponent
{
	public class _OrderSummaryComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}