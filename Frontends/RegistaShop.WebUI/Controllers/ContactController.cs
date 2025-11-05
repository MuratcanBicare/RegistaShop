using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ContactDtos;
using RegistaShop.WebUI.Services.CatalogServices.ContactServices;

namespace RegistaShop.WebUI.Controllers
{
	public class ContactController : Controller
	{

		private readonly IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.directory1 = "RegistaShop";
			ViewBag.directory2 = "İletişim";
			ViewBag.directory3 = "Mesaj Gönder";
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(CreateContactDto createContactDto)
		{
			createContactDto.IsRead = false;
			createContactDto.SendDate = DateTime.Now;
			await _contactService.CreateContactAsync(createContactDto);
			return RedirectToAction("Index", "Default");
		}
	}
}