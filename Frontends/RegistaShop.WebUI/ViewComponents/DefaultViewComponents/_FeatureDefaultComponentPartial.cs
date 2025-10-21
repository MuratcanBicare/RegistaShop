using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.FeatureDtos;
using RegistaShop.WebUI.Services.CatalogServices.FeatureServices;
using System.Threading.Tasks;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _FeatureDefaultComponentPartial : ViewComponent
	{

		private readonly IFeatureService _featureService;

		public _FeatureDefaultComponentPartial(IFeatureService featureService)
		{
			_featureService = featureService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _featureService.GetAllFeatureAsync();
			return View(values);
		}
	}
}