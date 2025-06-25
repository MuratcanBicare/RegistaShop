using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult _UILayout()
		{
			return View();
		}
	}
}
