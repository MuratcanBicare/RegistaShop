﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.FeatureSliderDtos;
using RegistaShop.WebUI.Services.CatalogServices.FeatureSliderServices;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _CarouselDefaultComponentPartial : ViewComponent
	{

		private readonly IFeatureSliderService _featureSliderService;

		public _CarouselDefaultComponentPartial(IFeatureSliderService featureSliderService)
		{
			_featureSliderService = featureSliderService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _featureSliderService.GetAllFeatureSliderAsync();
			return View(values);
		}
	}
}