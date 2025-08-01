﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.FeatureSliderDtos;

namespace RegistaShop.WebUI.ViewComponents.DefaultViewComponents
{
	public class _CarouselDefaultComponentPartial : ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public _CarouselDefaultComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			
			var client = _httpClientFactory.CreateClient();
			var response = await client.GetAsync("https://localhost:7245/api/FeatureSliders");
			if (response.IsSuccessStatusCode)
			{
				var jsonData = await response.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultFeatureSliderDto>>(jsonData);
				return View(values);
			}

			return View();

		}

	}
}
