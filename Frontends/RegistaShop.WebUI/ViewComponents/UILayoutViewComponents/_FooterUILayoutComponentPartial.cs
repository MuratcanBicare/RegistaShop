using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegistaShop.DtoLayer.CatalogDtos.AboutDtos;
using RegistaShop.WebUI.Services.CatalogServices.AboutServices;
using System.Net.Http.Headers;

namespace RegistaShop.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _FooterUILayoutComponentPartial : ViewComponent
	{

		private readonly IAboutService _aboutService;

		public _FooterUILayoutComponentPartial(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _aboutService.GetAllAboutAsync();
			return View(values);
		}
	}
}