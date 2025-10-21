using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.SpecialOfferDtos;
using RegistaShop.WebUI.Services.CatalogServices.SpecialOfferServices;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _SpecialOfferComponentPartial : ViewComponent
	{

		private readonly ISpecialOfferService _specialOfferService;

		public _SpecialOfferComponentPartial(ISpecialOfferService specialOfferService)
		{
			_specialOfferService = specialOfferService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _specialOfferService.GetAllSpecialOfferAsync();
			return View(values);
		}
	}
}