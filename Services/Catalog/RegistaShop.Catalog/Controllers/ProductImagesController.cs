﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Catalog.Dtos.ProductImageDtos;
using RegistaShop.Catalog.Services.ProductImageServices;


namespace RegistaShop.Catalog.Controllers
{
	
	public class ProductImagesController : ApiBaseController
	{

		private readonly IProductImageService _productImageService;

		public ProductImagesController(IProductImageService productImageService)
		{
			_productImageService = productImageService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductImageList()
		{

			var values = await _productImageService.GetAllProductImageAsync();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductImageById(string id)
		{

			var values = await _productImageService.GetByIdProductImageAsync(id);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> CreateProductImage(CreateProductImageDto createProductImageDto)
		{

			await _productImageService.CreateProductImageAsync(createProductImageDto);
			return Ok("Ürüne ait görseller başarılıyla eklendi.");

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProductImage(string id)
		{

			await _productImageService.DeleteProductImageAsync(id);
			return Ok("Ürüne ait görseller başarıyla silindi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
		{

			await _productImageService.UpdateProductImageAsync(updateProductImageDto);
			return Ok("Ürüne ait görseller başarıyla güncellendi.");

		}

	}
}
