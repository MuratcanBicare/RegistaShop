﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RegistaShop.DtoLayer.CatalogDtos.ContactDtos;

namespace RegistaShop.WebUI.Controllers
{
	public class ContactController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public ContactController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(CreateContactDto createContactDto)
		{
			createContactDto.IsRead = false;
			createContactDto.SendDate = DateTime.Now;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createContactDto);
			StringContent stringContent = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:7245/api/Contacts", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index", "Default");
			}

			return View();

		}
	}
}