using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegistaShop.DtoLayer.CatalogDtos.CategoryDtos;
using RegistaShop.WebUI.Services.CatalogServices.CategoryServices;
using System.Net.Http.Headers;

namespace RegistaShop.WebUI.ViewComponents.UILayoutViewComponents
{
	public class _NavbarUILayoutComponentPartial : ViewComponent
	{

		private readonly ICategoryService _categoryService;

		public _NavbarUILayoutComponentPartial(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _categoryService.GetAllCategoryAsync();
			return View(values);
		}
	}
}