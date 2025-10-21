using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.OfferDiscountDtos;
using RegistaShop.WebUI.Services.CatalogServices.OfferDiscountServices;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _OfferDiscountDefaultComponentPartial : ViewComponent
	{

		private readonly IOfferDiscountService _offerDiscountService;

		public _OfferDiscountDefaultComponentPartial(IOfferDiscountService offerDiscountService)
		{
			_offerDiscountService = offerDiscountService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _offerDiscountService.GetAllOfferDiscountAsync();
			return View(values);
		}
	}
}