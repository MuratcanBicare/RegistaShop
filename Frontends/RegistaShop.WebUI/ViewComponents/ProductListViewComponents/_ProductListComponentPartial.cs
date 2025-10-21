using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ProductDtos;
using RegistaShop.WebUI.Services.CatalogServices.ProductServices;
using System.Collections.Specialized;

namespace RegistaShop.WebUI.ViewComponents.ProductListViewComponents
{
	public class _ProductListComponentPartial : ViewComponent
	{

		private readonly IProductService _productService;

		public _ProductListComponentPartial(IProductService productService)
		{
			_productService = productService;
		}

		public async Task<IViewComponentResult> InvokeAsync(string id)
		{
			var values = id == null ? await _productService.GetProductsWithCategoryAsync() : await _productService.GetProductsWithByCategoryIdAsync(id);
			return View(values);
		}
	}
}
