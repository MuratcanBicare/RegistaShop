using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ProductDtos;
using RegistaShop.WebUI.Services.CatalogServices.ProductServices;

namespace RegistaShop.WebUI.ViewComponents.ProductDetailViewComponents
{
	public class _ProductDetailFeatureComponentPartial : ViewComponent
	{

		private readonly IProductService _productService;

		public _ProductDetailFeatureComponentPartial(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IViewComponentResult> InvokeAsync(string id)
		{
			var value = await _productService.GetByIdProductAsync(id);
			return View(value);
		}
	}
}