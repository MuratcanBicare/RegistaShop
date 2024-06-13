﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RegistaShop.Catalog.Dtos.ProductDtos;
using RegistaShop.Catalog.Services.ProductServices;

namespace RegistaShop.Catalog.Controllers
{
	[Authorize]
	public class ProductsController : ApiBaseController
	{

		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public async Task<IActionResult> ProductList()
		{

			var values = await _productService.GetAllProductsAsync();
			return Ok(values);

		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductById(string id)
		{

			var values = await _productService.GetByIdProductAsync(id);
			return Ok(values);

		}

		[HttpPost]
		public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
		{

			await _productService.CreateProductAsync(createProductDto);
			return Ok("Ürün başarılıyla eklendi.");

		}

		[HttpDelete]
		public async Task<IActionResult> DeleteProduct(string id)
		{

			await _productService.DeleteProductAsync(id);
			return Ok("Ürün başarıyla silindi.");

		}

		[HttpPut]
		public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
		{

			await _productService.UpdateProductAsync(updateProductDto);
			return Ok("Ürün başarıyla güncellendi.");

		}

	}
}
