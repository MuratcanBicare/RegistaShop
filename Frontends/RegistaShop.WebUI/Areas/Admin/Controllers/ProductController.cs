using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.CategoryDtos;
using RegistaShop.DtoLayer.CatalogDtos.ProductDtos;
using System.Text;

namespace RegistaShop.WebUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	[Route("Admin/Product")]
	public class ProductController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public ProductController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[Route("Index")]
		public async Task<IActionResult> Index()
		{
			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Ürünler";
			ViewBag.v3 = "Ürün Listesi";
			ViewBag.v0 = "Ürün İşlemleri";

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7245/api/Products");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
				return View(values);
			}

			return View();

		}

		[Route("ProductListWithCategory")]
		public async Task<IActionResult> ProductListWithCategory()
		{

			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Ürünler";
			ViewBag.v3 = "Ürün Listesi";
			ViewBag.v0 = "Ürün İşlemleri";

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7245/api/Products/ProductListWithCategory");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultProductWithCategoryDto>>(jsonData);
				return View(values);
			}

			return View();

		}

		[Route("CreateProduct")]
		[HttpGet]
		public async Task<IActionResult> CreateProduct()
		{

			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Ürünler";
			ViewBag.v3 = "Ürün Listesi";
			ViewBag.v0 = "Ürün İşlemleri";

			var client = _httpClientFactory.CreateClient();
			var resposponseMessage = await client.GetAsync("https://localhost:7245/api/Categories");
			var jsonDatae = await resposponseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonDatae);
			List<SelectListItem> categoryValues = (from x in values
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID
												   }).ToList();

			ViewBag.CategoryValues = categoryValues;
			return View();

		}

		[Route("CreateProduct")]
		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{

			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createProductDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7245/api/Products", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Product", new { area = "Admin" });
			}

			return View();

		}

		[Route("DeleteProduct/{id}")]
		public async Task<IActionResult> DeleteProduct(string id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7245/api/Products?id={id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Product", new { area = "Admin" });
			}

			return View();
		}

		[Route("UpdateProduct/{id}")]
		[HttpGet]
		public async Task<IActionResult> UpdateProduct(string id)
		{
			ViewBag.v1 = "Ana Sayfa";
			ViewBag.v2 = "Ürünler";
			ViewBag.v3 = "Ürün Güncelleme Sayfası";
			ViewBag.v0 = "Ürün İşlemleri";

			var client = _httpClientFactory.CreateClient();
			var respposeMessageCategories = await client.GetAsync("https://localhost:7245/api/Categories");
			var jsonDataCategories = await respposeMessageCategories.Content.ReadAsStringAsync();
			var valuesCategories = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonDataCategories);
			List<SelectListItem> categoryValues = (from x in valuesCategories
												   select new SelectListItem
												   {
													   Text = x.CategoryName,
													   Value = x.CategoryID
												   }).ToList();
			ViewBag.CategoryValues = categoryValues;


			var responseMessage = await client.GetAsync($"https://localhost:7245/api/Products/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[Route("UpdateProduct/{id}")]
		[HttpPost]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateProductDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:7245/api/Products/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Product", new { area = "Admin" });
			}
			return View();
		}
	}
}