using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Controllers
{
	public class ShoppingCartController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
