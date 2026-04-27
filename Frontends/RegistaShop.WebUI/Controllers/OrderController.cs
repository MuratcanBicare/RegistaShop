using Microsoft.AspNetCore.Mvc;

namespace RegistaShop.WebUI.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{

			ViewBag.directory1 = "RegistaShop";
			ViewBag.directory2 = "Siparişler";
			ViewBag.directory3 = "Sipariş Listesi";

			return View();
		}
	}
}
