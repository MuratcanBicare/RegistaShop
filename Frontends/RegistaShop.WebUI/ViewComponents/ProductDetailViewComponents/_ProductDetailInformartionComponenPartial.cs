using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ProductDetailDtos;

namespace RegistaShop.WebUI.ViewComponents.ProductDetailViewComponents
{
	public class _ProductDetailInformartionComponenPartial : ViewComponent
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public _ProductDetailInformartionComponenPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync(string id)
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:7245/api/ProductDetails/GetProductDetailByProductId?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<ResultProductDetailDto>(jsonData);
				return View(values);
			}
			return View();

		}

	}
}
