using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.AboutDtos;
using RegistaShop.WebUI.Services.CatalogServices.AboutServices;
using System.Text;

namespace RegistaShop.WebUI.Areas.Admin.Controllers
{

	[Area("Admin")]
	[Route("Admin/About")]
	public class AboutController : Controller
	{

		private readonly IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		[Route("Index")]
		public async Task<IActionResult> Index()
		{
			AboutViewBagList();

			var values = await _aboutService.GetAllAboutAsync();
			return View(values);
		}

		[HttpGet]
		[Route("CreateAbout")]
		public IActionResult CreateAbout()
		{
			AboutViewBagList();
			return View();
		}

		[HttpPost]
		[Route("CreateAbout")]
		public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
		{
			await _aboutService.CreateAboutAsync(createAboutDto);
			return RedirectToAction("Index", "About", new { area = "Admin" });
		}

		[Route("DeleteAbout/{id}")]
		public async Task<IActionResult> DeleteAbout(string id)
		{
			await _aboutService.DeleteAboutAsync(id);
			return RedirectToAction("Index", "About", new { area = "Admin" });
		}

		[Route("UpdateAbout/{id}")]
		[HttpGet]
		public async Task<IActionResult> UpdateAbout(string id)
		{
			AboutViewBagList();

			var value = await _aboutService.GetByIdAboutAsync(id);
			return View(value);
		}

		[Route("UpdateAbout/{id}")]
		[HttpPost]
		public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
		{

			await _aboutService.UpdateAboutAsync(updateAboutDto);
			return RedirectToAction("Index", "About", new { area = "Admin" });
		}

		void AboutViewBagList()
		{
			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Hakkımızda";
			ViewBag.v3 = "Hakkımızda Listesi";
			ViewBag.v0 = "Hakkımızda İşlemleri";
		}
	}
}