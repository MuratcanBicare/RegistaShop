using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ProductDtos;
using RegistaShop.WebUI.Services.CatalogServices.ProductServices;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _FeatureProductsDefaultComponentPartial : ViewComponent
	{

		private readonly IProductService _productService;

		public _FeatureProductsDefaultComponentPartial(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _productService.GetAllProductAsync();
			return View(values);
		}
	}
}