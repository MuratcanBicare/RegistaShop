using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.OrderViewComponent
{
	public class _OrderDetailComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}