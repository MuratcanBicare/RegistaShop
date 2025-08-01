﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Catalog.Dtos.SpecialOfferDtos;
using RegistaShop.Catalog.Services.SpecialOfferServices;

namespace RegistaShop.Catalog.Controllers
{
	public class SpecialOffersController : ApiBaseController
	{

		private readonly ISpecialOfferService _specialOfferService;

		public SpecialOffersController(ISpecialOfferService specialOfferService)
		{
			_specialOfferService = specialOfferService;
		}

		[HttpGet]
		public async Task<IActionResult> SpecialOfferList()
		{
			var values = await _specialOfferService.GetAllSpecialOfferAsync();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetSpecialOfferById(string id)
		{
			var values = await _specialOfferService.GetByIdSpecialOfferAsync(id);
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateSpecialOffer(CreateSpecialOfferDto createSpecialOfferDto)
		{
			await _specialOfferService.CreateSpecialOfferAsync(createSpecialOfferDto);
			return Ok("Özel Teklif başarıyla eklendi.");
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteSpecialOffer(string id)
		{
			await _specialOfferService.DeleteSpecialOfferAsync(id);
			return Ok("Özel Teklif başarıyla silindi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateSpecialOffer(UpdateSpecialOfferDto updateSpecialOfferDto)
		{
			await _specialOfferService.UpdateSpecialOfferAsync(updateSpecialOfferDto);
			return Ok("Özel Teklif başarıyla güncellendi.");
		}
	}
}