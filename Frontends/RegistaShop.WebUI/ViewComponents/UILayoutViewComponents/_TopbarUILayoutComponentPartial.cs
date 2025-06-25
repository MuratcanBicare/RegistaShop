using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _TopbarUILayoutComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
