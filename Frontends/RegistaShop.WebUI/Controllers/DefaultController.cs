using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			var user = User.Claims;
			int x;
			return View();
		}
	}
}
