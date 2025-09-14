using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
