using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CommentDtos;
using System.Threading.Tasks;

namespace RegistaShop.WebUI.Controllers
{
	public class ProductListController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public ProductListController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public IActionResult Index(string id)
		{
			ViewBag.i = id;
			return View();
		}

		public IActionResult ProductDetail(string id)
		{
			ViewBag.x = id;
			return View();
		}

		[HttpGet]
		public PartialViewResult AddCommentAsync()
		{
			return PartialView();
		}

		[HttpPost]
		public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
		{
			createCommentDto.ImageUrl = "test";
			createCommentDto.Rating = 1;
			createCommentDto.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			createCommentDto.Status = false;
			createCommentDto.ProductId = "687127ef5f1e75b5324e4f4c";
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createCommentDto);
			StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7145/api/Comments", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Default");
			}
			return View();
		}
	}
}