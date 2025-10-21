using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ProductDetailDtos;
using RegistaShop.WebUI.Services.CatalogServices.ProductDetailServices;

namespace RegistaShop.WebUI.ViewComponents.ProductDetailViewComponents
{
	public class _ProductDetailInformartionComponenPartial : ViewComponent
	{

		private readonly IProductDetailService _productDetailService;

		public _ProductDetailInformartionComponenPartial(IProductDetailService productDetailService)
		{
			_productDetailService = productDetailService;
		}

		public async Task<IViewComponentResult> InvokeAsync(string id)
		{
			var value = await _productDetailService.GetByProductIdProductDetailAsync(id);
			return View(value);
		}
	}
}