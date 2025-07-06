using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Areas.Admin.ViewComponents.AdminLayoutViewComponents
{
	public class _AdminLayoutMainSectionViewbagComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{

			return View();
		
		}

	}
}
